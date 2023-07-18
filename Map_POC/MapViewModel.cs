using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls.Maps;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Map_POC
{
    public class MapViewModel
    {
        public ICommand MapClickedCommand { get; }
        private readonly ObservableCollection<PinModel> _pins;
        public IList<PinModel> Pins => _pins;

        public MapViewModel()
        {
            Location location= new Location();
            _pins = new ObservableCollection<PinModel>();
            MapClickedCommand = new RelayCommand<MapClickedEventArgs>(OnMapClick);
        }

        public void OnMapClick(MapClickedEventArgs e)
        {
            PinModel newPin = new PinModel(
                Pins.Count,
                "Pin : " + Pins.Count,
                "adderss or any description",
                PinType.Place,
                e.Location
                );

            if (Pins.Count % 2 == 0)
            {
                newPin.ImageSource = ImageSource.FromFile("black_pin.png");
            }
            else
            {
                //newPin.ImageSource = ImageSource.FromFile("black_pin.png");
            }
            
            Pins.Add(newPin);
        }

    }
}
