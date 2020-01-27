using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ININ.IceLib.Configuration;

namespace OHBusyLightUI
{
    public partial class frmManage : Form
    {
        public ColorConfig _config;
        public bool _create = false;
        public ConfigurationManager _configurationManager;
        public List<ColorConfigMessageItems> _messages;
        public bool _readonly = false;
        public string _originalName;
        public bool _loading = false;

        public frmManage()
        {
            InitializeComponent();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManage_Load(object sender, EventArgs e)
        {
            _loading = true;
            dgMessages.DataSource = null;
            dgMessages.AutoGenerateColumns = false;

            dgTypes.DataSource = null;
            dgTypes.AutoGenerateColumns = false;

            GetMessages();


            if (!string.IsNullOrEmpty(_config.Name))
            {
                txtDefaultBlinkingThreshold.Text = _config.DefaultBlinkThreshold.ToString();
                txtName.Text = _config.Name;
                _originalName = _config.Name;

                dgTypes.DataSource = _config.StatusTypes;

                //comes in new then gen new messages, else use existing
                dgMessages.DataSource = _config.StatusMessages.Count == 0 ? _messages : _config.StatusMessages;
                
            }

            if (_readonly)
            {
                txtDefaultBlinkingThreshold.Enabled = false;
                txtName.Enabled = false;
                dgMessages.ReadOnly = true;
                dgTypes.ReadOnly = true;
                btnSave.Enabled = false;

            }

            _loading = false;


        }
        private void GetMessages()
        {


            if (_configurationManager != null)
            {

                List<ColorConfigMessageItems> messages = new List<ColorConfigMessageItems>();

                var configurationList = new StatusMessageConfigurationList(_configurationManager);
                var querySettings = configurationList.CreateQuerySettings();

                //querySettings.SetFilterDefinition(StatusMessageConfiguration.Property.Id,);
                querySettings.SetPropertiesToRetrieve(new[] { StatusMessageConfiguration.Property.MessageText, StatusMessageConfiguration.Property.GroupTagKey });

                configurationList.StartCaching(querySettings);


                configurationList.GetConfigurationList();



                foreach (var configurationObject in configurationList.GetConfigurationList())
                {
                    var uncut = configurationObject.MessageText.Value.ToString().Replace("DefaultValue=", "").Replace("; Items=[(en-US: )]", "");

                    messages.Add(new ColorConfigMessageItems { Name = uncut, Type = configurationObject.GroupTagKey.Value, BlinkDelay = 0, Color = string.Empty });
                    // _toast.Notify(uncut + " /  " + configurationObject.GroupTagKey.Value  , "messages", NotificationType.Info, TimeSpan.FromSeconds(10));

                }

                configurationList.StopCaching();

                foreach (var message in messages)
                {
                    switch (message.Type)
                    {
                        case "AVAILABLE":
                            message.Color = "GREEN";
                            break;
                        case "BREAK":
                            message.Color = "RED";
                            break;
                        case "FOLLOWUP":
                            message.Color = "YELLOW";
                            break;
                        case "TRAINING":
                            message.Color = "BLUE";
                            break;
                        case "UNAVAILABLE":
                            message.Color = "RED";
                            break;
                        default:
                            message.Color = "GREEN";
                            break;
                    }
                }



                _messages = messages;

            }



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validate
            if (CheckErrors())
            {
                try
                {
                    //Build out the object to serialize into a json file
                    ColorConfig config = new ColorConfig();

                    config.Name = txtName.Text;
                    config.DefaultBlinkThreshold = int.Parse(txtDefaultBlinkingThreshold.Text);
                    config.StatusTypes = (List<ColorConfigItems>)dgTypes.DataSource;
                    config.StatusMessages = (List<ColorConfigMessageItems>)dgMessages.DataSource;

                    string fileLocation = @"I:\apps\ININColorSchemes\" + txtName.Text + ".json";

                    //Delete the old file to make way for the new one
                    if (File.Exists(@fileLocation))
                    {
                        if (_originalName != txtName.Text)
                        {
                            var result = MessageBox.Show("Profile with that name already exists. do you want to Overwrite it?", "Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (result == DialogResult.Yes)
                            {
                                File.Delete(@fileLocation);

                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            File.Delete(@fileLocation);
                        }
                        
                        
                    }

                    //Make it available for use
                    File.WriteAllText(@fileLocation, JsonConvert.SerializeObject(config));

                    //Make sure it was written and then let the user know
                    if (File.Exists(@fileLocation))
                    {
                        var message = _create ? "Schema has been created successfully." : "Schema has been modified sucessfully.";
                        var messagecap = _create ? "Created" : "Updated";
                        var result = MessageBox.Show(message, messagecap, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (result == DialogResult.OK)
                        {
                            this.Close();
                        }


                    }
                }
                catch (Exception)
                {

                    throw;
                }


            }
            else
            {
                MessageBox.Show("Please correct the errors on the page before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            



        }
        private bool CheckErrors()
        {
            if (!string.IsNullOrEmpty(errError.GetError(txtName)))
            {
                return false;
            }

            if (!string.IsNullOrEmpty(errError.GetError(txtDefaultBlinkingThreshold)))
            {
                return false;
            }
            if (string.Equals(txtName.Text, "New"))
            {
                errError.SetError(this.txtName, "New is an invalid name. Please choose another.");
                return false;
            }



            return true;
        }
        private void txtName_Validated(object sender, EventArgs e)
        {
            if (string.Equals(txtName.Text, "New"))
            {
                errError.SetError(this.txtName, "New is an invalid name. Please choose another.");
                return;
            }

            if (string.Equals(txtName.Text, "Default"))
            {
                errError.SetError(this.txtName, "Default is an invalid name. Please choose another.");
                return;
            }

            if (txtName.Text.Length < 3)
            {
                errError.SetError(this.txtName, "Please enter a name that is at least three characters long.");
                return;
            }

            if (txtName.Text.Contains(":") || txtName.Text.Contains(@"\"))
            {
                errError.SetError(this.txtName, @"Name can not contain the : or \ symbol.");
                return;
            }
            // Clear the error, if any, in the error provider.
            errError.SetError(this.txtName, String.Empty);
        }

        private void txtDefaultBlinkingThreshold_Validated(object sender, EventArgs e)
        {
            int blink;

            if (int.TryParse(txtDefaultBlinkingThreshold.Text, out blink))
            {
                if (blink < 0)
                {

                    errError.SetError(this.txtDefaultBlinkingThreshold, "Please enter a whole positive number");
                    return;
                }


                // Clear the error, if any, in the error provider.
                errError.SetError(this.txtDefaultBlinkingThreshold, String.Empty);
            }
            else
            {
                errError.SetError(this.txtDefaultBlinkingThreshold, "Please enter a whole positive number");
                return;

            }
        }

        private void dgTypes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(BlinkType_KeyPress);
            if (dgTypes.CurrentCell.ColumnIndex == dgTypes.Columns["colBlinkDelay"].Index || dgTypes.CurrentCell.ColumnIndex == dgTypes.Columns["colBlinkRate"].Index) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(BlinkType_KeyPress);
                }
            }
        }
        private void BlinkType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgMessages_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(BlinkMessage_KeyPress);
            if (dgMessages.CurrentCell.ColumnIndex == dgMessages.Columns["colMessageBlinkDelay"].Index || dgMessages.CurrentCell.ColumnIndex == dgMessages.Columns["colMessageBlinkRate"].Index) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(BlinkMessage_KeyPress);
                }
            }
        }
        private void BlinkMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void linkCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            var result = MessageBox.Show("Would you like to copy the colors from the types over to the messages of those types?", "Color Copy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string type = string.Empty;
                string color = string.Empty;

                foreach (DataGridViewRow row in dgTypes.Rows)
                {
                    type = row.Cells["colName"].Value.ToString();
                    color = row.Cells["colColor"].Value.ToString();


                    foreach (DataGridViewRow row1 in dgMessages.Rows)
                    {

                        string type2 = string.Empty;

                        if (row1.Cells["colMessageType"].Value != null)
                        {
                            type2 = row1.Cells["colMessageType"].Value.ToString();

                            if (type == type2)
                            {
                                row1.Cells["colMessageColor"].Value = color;

                            }
                        }


                        

                    }
                        

                }

            }

        }

        private void dgTypes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            //dgTypes.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        private void dgMessages_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            //dgMessages.Rows[e.RowIndex].ErrorText = string.Empty;

        }

        private void dgTypes_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    dgTypes.EditingControl.Text = "0";
                }
            }
        }

        private void dgMessages_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    dgMessages.EditingControl.Text = "0";
                }
            }
        }
    }
}
