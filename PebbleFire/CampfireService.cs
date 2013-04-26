using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PebbleFire
{
    public class CampfireService : ICampfireService
    {
        public ObservableCollection<ICampfireRoom> Rooms
        {
            get { throw new NotImplementedException(); }
        }
    }
}
