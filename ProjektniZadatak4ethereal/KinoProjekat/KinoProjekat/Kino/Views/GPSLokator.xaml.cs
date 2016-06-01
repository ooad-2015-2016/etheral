using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace KinoProjekat.Kino.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GPSLokator : Page
    {
        public GPSLokator()
        {
            this.InitializeComponent();
        }

        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        public async void Lokacija(object sender, RoutedEventArgs e)
        {
            var accessStatus = await Geolocator.RequestAccessAsync();

            MessageDialog dialog = new MessageDialog("Dobavljam Lokaciju");
            dialog.Commands.Add(new UICommand("Ok"));
            dialog.DefaultCommandIndex = 0;
            await dialog.ShowAsync();
            // If DesiredAccuracy or DesiredAccuracyInMeters are not set (or value is 0), DesiredAccuracy.Default is used.
            Geolocator geolocator = new Geolocator { DesiredAccuracyInMeters = 1000 };

            // Subscribe to the StatusChanged event to get updates of location status changes.
            //  geolocator.StatusChanged += OnStatusChanged;

            // Carry out the operation.
            Geoposition pos = await geolocator.GetGeopositionAsync();



            UpdateLocationData(pos);
        }

        private void DisplayIcon(double x, double y, MapControl MapControl1)
        {
            BasicGeoposition snPosition = new BasicGeoposition() { Latitude = x, Longitude = y };
            Geopoint snPoint = new Geopoint(snPosition);

            // Create a MapIcon.
            MapIcon mapIcon1 = new MapIcon();
            mapIcon1.Location = snPoint;
            mapIcon1.NormalizedAnchorPoint = new Point(0.5, 1.0);
            mapIcon1.Title = "Pin";
            mapIcon1.ZIndex = 0;

            // Add the MapIcon to the map.
            MapControl1.MapElements.Add(mapIcon1);
            // MapControl1.MapElements.Add(new MapIcon() { Location = new Geopoint(new BasicGeoposition() { Latitude = x - 5, Longitude = y } ), NormalizedAnchorPoint = new Point(0.5, 1.0), Title = "Pin", ZIndex=0 });

            // Center the map over the POI.
            MapControl1.Center = snPoint;
            MapControl1.ZoomLevel = 14;
            textBlock.Text = x.ToString();
            textBlock1.Text = y.ToString();
        }

        private void UpdateLocationData(Geoposition pos)
        {
            //MessageDialog dialog = new MessageDialog(String.Format("Latitude: {0} Longitude: {1}",
            // pos.Coordinate.Latitude, pos.Coordinate.Longitude));

            Longitude = pos.Coordinate.Longitude;
            Latitude = pos.Coordinate.Latitude;
            DisplayIcon(Latitude, Longitude, Mapa);
            //dialog.Commands.Add(new UICommand("Ok"));
            //dialog.DefaultCommandIndex = 0;
            //await dialog.ShowAsync();
        }

    }
}
