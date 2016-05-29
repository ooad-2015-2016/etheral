using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class Otkazivanje : Page
    {
        public Otkazivanje()
        {
            this.InitializeComponent();
        }

        private void ImageBrush_ImageOpened(object sender, RoutedEventArgs e)
        {

        }
        private void buttonNazad_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pocetna));
        }
        private void textBoxIme_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private async void buttonOtkazi_Click(object sender, RoutedEventArgs e)
        {
            String kod = textBoxIme.ToString();
            if (kod == "")// OVDJE DA LI JE DOBAR KOD PROVJERAVA// OVO SAM BEZVEZE NAPISALA
            {
                this.Frame.Navigate(typeof(ZavrsnaForma));
            }
            else
            {
                MessageDialog dialog = new MessageDialog("Unesite kod!", "Upozorenje");
                await dialog.ShowAsync();
            }

        }
    }
}
