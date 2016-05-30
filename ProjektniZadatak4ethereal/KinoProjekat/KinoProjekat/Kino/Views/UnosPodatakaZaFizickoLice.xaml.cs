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
using KinoProjekat.Kino.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace KinoProjekat.Kino.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UnosPodatakaZaFizickoLice : Page
    {
        List<Models.FizickoLice> Flica = new List<Models.FizickoLice>();
        public UnosPodatakaZaFizickoLice()
        {
            this.InitializeComponent();
          
        }

        private async void buttonName_Click(object sender, RoutedEventArgs e)
        {


            if (textBoxEmail.ToString() == textBoxPotvrdaEmail.ToString())
            {
                Flica.Add(new Models.FizickoLice(textBoxIme.ToString(), textBoxPrezime.ToString(), textBoxTelefon.ToString(), textBoxEmail.ToString(), textBoxAdresa.ToString(), Models.StatusFizickogLica.dijete, Models.TipKorisnika.InternetKorisnik));
                this.Frame.Navigate(typeof(Sala));
            }
            else
            {
                //Poruka za nepravilan unos email
                textBoxEmail.Text = " ";
                textBoxPotvrdaEmail.Text = " ";

            }
            // (string ime, string prezime, string telefon, string email, string adresa, StatusFizickogLica status, TipKorisnika tip)

            using (var db = new LiceDbContext())
            {
                var contact = new Lice
                {
                    Ime = textBoxIme.Text,
                    Prezime = textBoxPrezime.Text,
                    Email = textBoxEmail.Text,
                    Telefon = textBoxTelefon.Text,

                };
                db.SveLica.Add(contact);
                //SaveChanges obavezno da se reflektuju izmjene u bazi, tek tada dolazi do komunikacije

                db.SaveChanges();
                //reset polja za unos
                textBoxIme.Text = string.Empty;
                textBoxPrezime.Text = string.Empty;
                textBoxEmail.Text = string.Empty;
                textBoxTelefon.Text = string.Empty;
                textBoxPotvrdaEmail.Text = string.Empty;

            }


        }

        private void buttonNazad_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OdabirFilma));
        }
    }
}
