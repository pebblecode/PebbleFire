using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PebbleFire
{
    public class RoomViewModel : ViewModelBase
    {
        private ICampfireRoom room;
        private bool selected;
        private MainViewModel mainViewModel;

        public RoomViewModel(MainViewModel mainViewModel, ICampfireRoom room)
        {
            this.mainViewModel = mainViewModel;
            this.room = room;
        }

        public string Name
        {
            get { return room.Name; }
        }

        public ObservableCollection<CampfireMessage> Messages
        {
            get { return room.Messages; }
        }

        public bool IsSelected
        {
            get { return selected; }
            set
            {
                selected = value;
                if (selected)
                    this.mainViewModel.RoomSelected(this);
                RaisePropertyChanged(() => IsSelected);
            }
        }
    }
}
