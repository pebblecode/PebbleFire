using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinyIoC;

namespace PebbleFire
{
    public class ViewModelLocator
    {
        TinyIoCContainer container;
        bool registered;

        public ViewModelLocator()
        {
            this.container = TinyIoCContainer.Current;

            Register();
        }

        private void Register()
        {
            if (!registered)
            {
                if (IsInDesignMode())
                {
                    RegisterDesignerTypes();
                }
                else
                {
                    container.AutoRegister();
                }
                registered = true;
            }
        }

        private bool IsInDesignMode()
        {
            //return WpfDesigner.IsInDesignMode();
            return true;
        }

        private void RegisterDesignerTypes()
        {
            var campfireService = new DesignerCampfireService();
            container.Register<ICampfireService>(campfireService);
        }

        public MainViewModel MainViewModel
        {
            get
            {
                Register();
                return (MainViewModel)container.Resolve(typeof(MainViewModel));
            }
        }
    }
}
