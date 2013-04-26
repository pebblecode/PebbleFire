using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PebbleFire
{
    public class MainViewModel : ViewModelBase
    {
        private ICampfireService campfireService;
        private RoomViewModel selectedRoom;

        public MainViewModel(ICampfireService campfireService)
        {
            this.campfireService = campfireService;

            Rooms = new ObservableCollection<RoomViewModel>();
            AddRooms();

            SelectedRoom = Rooms.FirstOrDefault();
        }

        private void AddRooms()
        {
            foreach (ICampfireRoom room in campfireService.Rooms)
            {
                var viewModel = new RoomViewModel(this, room);
                Rooms.Add(viewModel);
            }
        }

        public ObservableCollection<RoomViewModel> Rooms { get; set; }

        public RoomViewModel SelectedRoom
        {
            get { return selectedRoom; }
            set
            {
                if (selectedRoom != value)
                {
                    UnselectRoom();
                    selectedRoom = value;
                    SelectRoom();
                    RaisePropertyChanged(() => SelectedRoom);
                }
            }
        }

        private void UnselectRoom()
        {
            SelectRoom(false);
        }

        private void SelectRoom()
        {
            SelectRoom(true);
        }

        private void SelectRoom(bool selected)
        {
            if (selectedRoom != null)
                selectedRoom.IsSelected = selected;
        }

        internal void RoomSelected(RoomViewModel room)
        {
            if (room.IsSelected)
            {
                SelectedRoom = room;
            }
        }
    }
}
