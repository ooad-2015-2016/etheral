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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace KinoProjekat.Kino.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Pocetna : Page
    {
        public Pocetna()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }

        private void buttonRezervacija_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OdabirFilma), false);
        }

        private void buttonOtkazi_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Otkazivanje));
        }

        private void buttonRepertoar_Click(object sender, RoutedEventArgs e)
        {
            
            this.Frame.Navigate(typeof(OdabirFilmaSamoRepertoar), true);
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Help));
        }
    }
}
