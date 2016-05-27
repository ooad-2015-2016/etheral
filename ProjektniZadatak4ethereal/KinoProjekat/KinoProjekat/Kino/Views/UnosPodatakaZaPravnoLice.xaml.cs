using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class UnosPodatakaZaPravnoLice : Page
    {
        List<Models.PravnoLice> Plica = new List<Models.PravnoLice>();
        public UnosPodatakaZaPravnoLice()
        {
            this.InitializeComponent();
            
        }

        private void buttonName_Click(object sender, RoutedEventArgs e)
        {
            Models.Firma firma = new Models.Firma(textBoxNaziv.ToString(), textBoxAdresaPravnog.ToString(), textBoxRacun.ToString());
            //firme.Add(new Models.Firma(textBoxNaziv, textBoxAdresaPravnog, textBoxRacun);
            if (textBoxEmail.ToString() == textBoxPotvrdaEmail.ToString())
            {
                Plica.Add(new Models.PravnoLice(textBoxIme.ToString(), textBoxPrezime.ToString(), textBoxTelefon.ToString(), textBoxEmail.ToString(), firma, textBoxBrojLicne.ToString()));
                this.Frame.Navigate(typeof(Sala));
                
            }
            else
            {
                //Poruka za nepravilan unos email
                textBoxEmail.Text = " ";
                textBoxPotvrdaEmail.Text = " ";

            }

        }

        private void buttonNazad_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OdabirFilma));
        }
    }
}
