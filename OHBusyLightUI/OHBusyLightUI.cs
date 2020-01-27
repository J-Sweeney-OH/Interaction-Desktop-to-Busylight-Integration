using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ININ.InteractionClient.AddIn;
using ININ.IceLib.Connection;
using ININ.IceLib.People;


namespace OHBusyLightUI
{
    public class OHBusyLightUI : AddInWindow
    {

        private Session _session;
        INotificationService _toast = null;

        public override object Content 
        { 
            get 
            {
                var window = new ColorSchemaUi();
                window._session = _session;
                window._toast = _toast;
                
                
                return window; 
            } 
        
        }

        protected override string Id {get { return "OHBusyLightColorSchemaMgmt"; } }

        protected override string DisplayName { get { return "OhioHealth BusyLight Color Schema Mgmt"; } }

        protected override string CategoryId { get { return "OhioHealthCustomApp"; } }

        protected override string CategoryDisplayName { get { return "OhioHealth Custom Apps"; } }


        public OHBusyLightUI()
        {

        }


        protected override void OnLoad(IServiceProvider serviceProvider)
        {
            base.OnLoad(serviceProvider);
            _session = (Session)serviceProvider.GetService(typeof(Session));

            _toast = (INotificationService)serviceProvider.GetService(typeof(INotificationService));


        }



    }
}
