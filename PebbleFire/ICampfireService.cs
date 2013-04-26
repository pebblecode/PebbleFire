using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PebbleFire
{
    public interface ICampfireService
    {
        ObservableCollection<ICampfireRoom> Rooms { get; }
    }
}
