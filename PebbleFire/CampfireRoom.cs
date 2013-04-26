using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PebbleFire
{
    public class CampfireRoom : ICampfireRoom
    {
        public CampfireRoom(string name)
        {
            this.Messages = new ObservableCollection<CampfireMessage>();
        }

        public string Name { get; private set; }

        public ObservableCollection<CampfireMessage> Messages { get; private set; }
    }
}
