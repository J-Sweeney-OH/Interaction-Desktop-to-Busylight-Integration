using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using ININ.IceLib.Connection;
using ININ.IceLib.People;
using ININ.InteractionClient.AddIn;
using ININ.IceLib.Configuration;

namespace OHBusyLightUI
{
    public partial class ColorSchemaUi : UserControl
    {
        private ColorConfig _config;
        public bool _refresh = false;
        public bool _roles = false;
        public Session _session;
        public INotificationService _toast;
        public PeopleManager _people;
        public ConfigurationManager _configurationManager;
        private bool loading;


        public ColorSchemaUi()
        {
            InitializeComponent();
        }

        private void ColorSchemaUi_Load(object sender, EventArgs e)
        {
            loading = true;

            //Read from local machine to get their current config
            GetCurrentSchema();
            //Pull current list of schemas on share drive to populate dropdown list
            RefreshSchemas();
            //If we have a valid session get some other things
            if (!string.IsNullOrEmpty(_session.ConnectionStateMessage))
            {
                GetPeopleManager();
                GetConfigurationManger();
                GetRoles(); 
            }


            linkNew.Enabled = _roles;

            loading = false;

        }

        private void GetPeopleManager()
        {
            _people = PeopleManager.GetInstance(_session);
        }
        private void GetConfigurationManger()
        {
            
            _configurationManager = ConfigurationManager.GetInstance(_session);
        }
        private void GetRoles()
        {

            if (_configurationManager != null)
            {
                //_toast.Notify(_configurationManager.Session.DisplayName, "config", NotificationType.Info, TimeSpan.FromSeconds(10));

                var configurationList = new RoleConfigurationList(_configurationManager);
                var querySettings = configurationList.CreateQuerySettings();

                querySettings.SetFilterDefinition(RoleConfiguration.Property.Id, "OHBusyLightConfig", FilterMatchType.Exact);
                querySettings.SetPropertiesToRetrieve(new[] { RoleConfiguration.Property.Users });

                configurationList.StartCaching(querySettings);

                foreach (var configurationObject in configurationList.GetConfigurationList())
                {

                    if (configurationObject.Users.Value.ToString().Contains(_session.UserId))
                    {
                        _roles = true;

                        //_toast.Notify(configurationObject.Users.Value.ToString(), "roles", NotificationType.Info, TimeSpan.FromSeconds(10));
                    }

                }

                configurationList.StopCaching();
            }

        }
        private void GetCurrentSchema()
        {
            try
            {
                ColorConfig config = new ColorConfig();
                
                string localLocation = System.Environment.ExpandEnvironmentVariables("%userprofile%/downloads/") + "ColorProfile.json";

                if (File.Exists(localLocation))
                {
                    using (StreamReader file = File.OpenText(localLocation))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        config = (ColorConfig)serializer.Deserialize(file, typeof(ColorConfig));

                    }

                    if (config.Name != null)
                    {
                        linkCurrentSchema.Text = config.Name;
                    }

                }
                else
                {
                    linkCurrentSchema.Text = string.Empty;
                }



            }
            catch (Exception)
            {

                throw;
            }
        }
        private void RefreshSchemas()
        {

            try
            {
                cbColorSchema.DataSource = null;
                
                string[] existingSchemas = Directory.GetFiles(@"I:\apps\ININColorSchemes\", "*.json");

                if (existingSchemas.Length > 0)
                {
                    List<SchemasLocationXref> files = new List<SchemasLocationXref>();

                    files.Add(new SchemasLocationXref { FileLocation = "", SchemaName = "" });

                    foreach (var file in existingSchemas)
                    {
                        var loc = file;
                        var name = file.Replace(".json", "").Remove(0, 25).Trim();

                        files.Add(new SchemasLocationXref { FileLocation = loc, SchemaName = name });


                    }

                    var sorted = files.OrderBy(x => x.SchemaName).Select(x => x).ToList();
                    cbColorSchema.ValueMember = "FileLocation";
                    cbColorSchema.DisplayMember = "SchemaName";
                    
                    cbColorSchema.DataSource = sorted;


                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnApply_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cbColorSchema.Text) )
            {
                return;
            }

            try
            {

                string fileLocation = @cbColorSchema.SelectedValue.ToString();
  
                string localLocation = System.Environment.ExpandEnvironmentVariables("%userprofile%/downloads/") + "ColorProfile.json";


                using (StreamReader file = File.OpenText(fileLocation))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    _config = (ColorConfig)serializer.Deserialize(file, typeof(ColorConfig));

                }


                //Delete the old file to make way for the new one
                if (File.Exists(localLocation))
                {
                    File.Delete(localLocation);
                }

                File.WriteAllText(localLocation, JsonConvert.SerializeObject(_config));

                using (StreamWriter file = File.CreateText(localLocation))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, _config);
                }

                //Clean up and let them know
                MessageBox.Show("Please restart Interaction Desktop to begin using the new color schema.", "New Schema Selected.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbColorSchema.SelectedIndex = -1;

                GetCurrentSchema();

            }
            catch (Exception ex )
            {
                MessageBox.Show("An Error occured" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
            }

   
        }

        private void cbColorSchema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loading)
            {

                if (cbColorSchema.SelectedIndex == -1)
                {
                    return;
                }

                if (!string.IsNullOrEmpty(cbColorSchema.SelectedValue.ToString()))
                {
                    string fileLocation = cbColorSchema.SelectedValue.ToString();

                    using (StreamReader file = File.OpenText(fileLocation))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        _config = (ColorConfig)serializer.Deserialize(file, typeof(ColorConfig));

                    }

                }

                if (string.Equals(_config.Name, "Default") || string.IsNullOrEmpty(cbColorSchema.Text) )
                {
                    linkDelete.Enabled = false;
                    linkEdit.Enabled = false;
                }
                else
                {
                    linkDelete.Enabled = _roles;
                    linkEdit.Enabled = _roles;
                }


            }
        }


        private void linkDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(cbColorSchema.Text) )
            {
                var result = MessageBox.Show("Do you want to delete this Schema?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    //Delete it out
                    if (File.Exists(@cbColorSchema.SelectedValue.ToString()))
                    {
                        File.Delete(@cbColorSchema.SelectedValue.ToString());
                    }

                    RefreshSchemas();
                }
            }
            
            

        }

        private void linkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (!string.IsNullOrEmpty(cbColorSchema.Text))
            {
                frmManage form = new frmManage();
                form._config = _config;
                form._create = false;
                form._configurationManager = _configurationManager;

                form.Show();
                RefreshSchemas();
            }
   
        }


        private void linkNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ColorConfig colorSchema = new ColorConfig();

            frmManage form = new frmManage();

            //lets see if the default exists and pull that in for them to change
            string fileLocation = @"I:\apps\ININColorSchemes\Default.json";

            if (File.Exists(@fileLocation))
            {
                using (StreamReader file = File.OpenText(fileLocation))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    _config = (ColorConfig)serializer.Deserialize(file, typeof(ColorConfig));
                    _config.Name = "New";
                    form._config = _config;

                }
            }
            else
            {
                colorSchema.Name = "New";
                colorSchema.DefaultBlinkThreshold = 0;

                List<ColorConfigItems> types = new List<ColorConfigItems>();
                types.Add(new ColorConfigItems { Name = "AVAILABLE", BlinkDelay = 0, Color = "GREEN" });
                types.Add(new ColorConfigItems { Name = "BREAK", BlinkDelay = 0, Color = "RED" });
                types.Add(new ColorConfigItems { Name = "FOLLOWUP", BlinkDelay = 0, Color = "YELLOW" });
                types.Add(new ColorConfigItems { Name = "TRAINING", BlinkDelay = 0, Color = "BLUE" });
                types.Add(new ColorConfigItems { Name = "UNAVAILABLE", BlinkDelay = 0, Color = "RED" });


                colorSchema.StatusTypes = types;

                List<ColorConfigMessageItems> messages = new List<ColorConfigMessageItems>();
                colorSchema.StatusMessages = messages;

                form._config = colorSchema;

            }

            
            form._create = true;
            form._configurationManager = _configurationManager;

            form.Show();
            RefreshSchemas();

        }

        private void linkRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetCurrentSchema();
            RefreshSchemas();
        }

        private void linkCurrentSchema_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (string.IsNullOrEmpty(linkCurrentSchema.Text))
            {
                return;
            }
            string localLocation = System.Environment.ExpandEnvironmentVariables("%userprofile%/downloads/") + "ColorProfile.json";


            using (StreamReader file = File.OpenText(localLocation))
            {
                JsonSerializer serializer = new JsonSerializer();
                _config = (ColorConfig)serializer.Deserialize(file, typeof(ColorConfig));

            }

            if (_config != null)
            {
                frmManage form = new frmManage();
                form._config = _config;
                form._create = false;
                form._readonly = true;
                form.Text = "Busylight Color Schema Editor - READ ONLY";
                form._configurationManager = _configurationManager;

                form.Show();
                RefreshSchemas();
            }



        }

        private void cbColorSchema_DropDown(object sender, EventArgs e)
        {
            
        }
    }
}
