using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PebbleFire
{
    public class DesignerCampfireService : ICampfireService
    {
        public DesignerCampfireService()
        {
            Rooms = new ObservableCollection<ICampfireRoom>();
            AddRoom("{code} .net dev");
            AddRoom("{code} Bede .net dev");
            AddRoom("{code} Evolution Integration");
        }

        private DesignerCampfireRoom AddRoom(string name)
        {
            var room = new DesignerCampfireRoom { Name = name };
            room.Messages.Add(new CampfireMessage { Text = "First message -" + name });
            room.Messages.Add(new CampfireMessage { Text = "Another message - " + name });
            Rooms.Add(room);
            return room;
        }

        public ObservableCollection<ICampfireRoom> Rooms { get; private set; }
    }
}
