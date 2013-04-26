using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PebbleFire
{
    public interface ICampfireRoom
    {
        string Name { get; }
        ObservableCollection<CampfireMessage> Messages { get; }
    }
}
