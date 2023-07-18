using Microsoft.Maui.Controls.Maps;

namespace Map_POC;

public partial class MainPage : ContentPage
{
    public MainPage(MapViewModel mapViewModel)
    {
        BindingContext = mapViewModel;
        InitializeComponent();
    }
    public void OnMarkerClicked(Object sender, PinClickedEventArgs e)
    {

    }

    public void OnInfoWindowClicked(Object sender, PinClickedEventArgs e)
    {
        e.HideInfoWindow = true;
    }
}

