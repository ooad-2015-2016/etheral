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
    public sealed partial class Detalji : Page
    {
        //public bool kojiJe;
        public Detalji()
        {

            this.InitializeComponent();
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //base.OnNavigatedTo(e);
            SystemNavigationManager.GetForCurrentView().BackRequested += Detalji_BackRequested;
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().BackRequested -= Detalji_BackRequested;
        }

        private void Detalji_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if (this.Frame.CanGoBack) this.Frame.GoBack();
        }

        private void buttonRezervisi_Click(object sender, RoutedEventArgs e)
        {
            /*if (kojiJe == true)
            {
                this.Frame.Navigate(typeof(UnosPodatakaZaPravnoLice));
            }*/
        //  else
           this.Frame.Navigate(typeof(UnosPodatakaZaFizickoLice));


        }

        /*private void buttonNazad_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OdabirFilma));
        }*/

        /*protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }*/
    }
}
