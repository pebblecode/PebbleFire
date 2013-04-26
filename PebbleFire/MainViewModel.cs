using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

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

            SettingsCommand = new RelayCommand(() => ShowSettings());
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

        public ICommand SettingsCommand { get; private set; }

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

        private void ShowSettings()
        {
        }
    }
}
