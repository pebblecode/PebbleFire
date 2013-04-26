using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PebbleFire
{
    public class DesignerCampfireRoom : ICampfireRoom
    {
        public DesignerCampfireRoom()
        {
            Messages = new ObservableCollection<CampfireMessage>();
        }

        public string Name { get; set; }
        public ObservableCollection<CampfireMessage> Messages { get; private set; }
    }
}
