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
using Windows.UI.Core;
using Windows.Storage;
using System.Net;

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

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().BackRequested += UnosPodatakaZaFizickoLice_BackRequested;
        }

        private void UnosPodatakaZaFizickoLice_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if (this.Frame.CanGoBack) this.Frame.GoBack();
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().BackRequested -= UnosPodatakaZaFizickoLice_BackRequested;
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
                db.Lice.Add(contact);
                //SaveChanges obavezno da se reflektuju izmjene u bazi, tek tada dolazi do komunikacije

                db.SaveChanges();
                //reset polja za unos
                textBoxIme.Text = string.Empty;
                textBoxPrezime.Text = string.Empty;
                textBoxEmail.Text = string.Empty;
                textBoxTelefon.Text = string.Empty;
                textBoxPotvrdaEmail.Text = string.Empty;

                string messageBody;
                messageBody = "Kod je bla bla bla";

                string mail;
                mail = textBoxEmail.Text;
                SendEmailOverMailTo(mail, "", " ", "Rezervacija", messageBody);

                ////////////////////////////////////////////////////////////////////////////////////////
               /* Windows.ApplicationModel.Contacts.Contact recipient;
                
                //StorageFile attachmentFile;
                //var emailMessage = new Windows.ApplicationModel.Email.EmailMessage();
                //emailMessage.Body = messageBody;

                if (attachmentFile != null)
                /{
                    var stream = Windows.Storage.Streams.RandomAccessStreamReference.CreateFromFile(attachmentFile);

                    var attachment = new Windows.ApplicationModel.Email.EmailAttachment(atachmentFile.Name,
                        stream);

                    emailMessage.Attachments.Add(attachment);
                }

               var email = recipient.Emails.FirstOrDefault<Windows.ApplicationModel.Contacts.ContactEmail>();
               
                if (email != null)

                {
                    var emailRecipient = new Windows.ApplicationModel.Email.EmailRecipient(email.Address);
                    emailMessage.To.Add(emailRecipient);
                }

                await Windows.ApplicationModel.Email.EmailManager.ShowComposeNewEmailAsync(emailMessage);*/

                ////////////////////////////////////////////////////////////////////////////////////////
            }


        }
        public static async void SendEmailOverMailTo(string recipient, string cc, string bcc, string subject, string body)
        {
            /*if (String.IsNullOrEmpty(recipient))
            {
                throw new ArgumentException("recipient must not be null or emtpy");
            }
            if (String.IsNullOrEmpty(subject))
            {
                throw new ArgumentException("subject must not be null or emtpy");
            }
            if (String.IsNullOrEmpty(body))
            {
                throw new ArgumentException("body must not be null or emtpy");
            }*/

            // Encode subject and body of the email so that it at least largely 
            // corresponds to the mailto protocol (that expects a percent encoding 
            // for certain special characters)
            string encodedSubject = WebUtility.UrlEncode(subject).Replace("+", " ");
            string encodedBody = WebUtility.UrlEncode(body).Replace("+", " ");

            // Create a mailto URI
            Uri mailtoUri = new Uri("mailto:" + recipient + "?subject=" +
               encodedSubject +
               (String.IsNullOrEmpty(cc) == false ? "&cc=" + cc : null) +
               (String.IsNullOrEmpty(bcc) == false ? "&bcc=" + bcc : null) +
               "&body=" + encodedBody);

            // Execute the default application for the mailto protocol
            await Windows.System.Launcher.LaunchUriAsync(mailtoUri);
        }

        /*private void buttonNazad_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OdabirFilma));
        }*/
    }
}
