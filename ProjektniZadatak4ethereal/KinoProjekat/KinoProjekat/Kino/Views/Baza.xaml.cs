using KinoProjekat.Kino.Models;
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
    public sealed partial class Baza : Page
    {
        public Baza()
        {
            this.InitializeComponent();
        }
        //samo da mozemo brisati iz baze
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            using (var db = new LiceDbContext())
            {
                listViewKorisnici.ItemsSource = db.Lice.ToList();
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DependencyObject dep = (DependencyObject)e.OriginalSource;

            while ((dep != null) && !(dep is ListViewItem))
            {
                dep = VisualTreeHelper.GetParent(dep);
            }

            if (dep == null)
                return;

            using (var db = new LiceDbContext())
            {
                db.Lice.Remove((Lice)listViewKorisnici.ItemFromContainer(dep));

                db.SaveChanges();

                listViewKorisnici.ItemsSource = db.Lice.OrderBy(c => c.Prezime).ToList();


            }
        }

        private void listViewKorisnici_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

