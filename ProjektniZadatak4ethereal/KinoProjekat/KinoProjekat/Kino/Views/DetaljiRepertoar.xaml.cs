using KinoProjekat.Kino.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
namespace KinoProjekat.Kino.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DetaljiRepertoar : Page
    {
        public Film film;
        public DetaljiRepertoar()
        {
            this.InitializeComponent();
        }

        private void buttonNazad_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OdabirFilmaSamoRepertoar));
        }
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            film = (Film)e.Parameter;

            Frame rootFrame = Window.Current.Content as Frame;

            if (rootFrame.CanGoBack)
            {
                // Show UI in title bar if opted-in and in-app backstack is not empty.
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                    AppViewBackButtonVisibility.Visible;
            }
            else
            {
                // Remove the UI from the title bar if in-app back stack is empty.
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                    AppViewBackButtonVisibility.Collapsed;
            }
            NazivFilma.Text = film.Naziv;
            OrginalniNaslov.Text = film.OrginalniNaziv;
            Zanr.Text = film.Zanr;
            Reziser.Text = film.Reziser;
            Ulogee.Text = film.Reziser;
            IMDB.Content = film.Link;
            Sinopsis.Text = film.Opis;
            WebStranica.Source = new Uri(film.VideoLink, UriKind.RelativeOrAbsolute);
            listViewTermini.ItemsSource = film.TerminiPrikazivanja;


            Uri uri = new Uri(film.Slika, UriKind.Absolute);
            ImageSource imgSource = new BitmapImage(uri);
            Slikaa.Source = imgSource;

        }
    }
}
