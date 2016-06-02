using KinoProjekat.Kino.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class OdabirFilmaSamoRepertoar : Page
    {
        public bool koji;
        private bool samoRepertoar = true;
        private ObservableCollection<MyFlipViewItem> items;
        //private ObservableCollection<MyGridViewItem> itemsG;
        private List<Film> Filmovi;
        public OdabirFilmaSamoRepertoar()
        {
            this.InitializeComponent();
            items = new ObservableCollection<MyFlipViewItem>();
            //itemsG = new ObservableCollection<MyGridViewItem>();

            flipViewPremijere.ItemsSource = items;
            //gridViewPonuda.ItemsSource = itemsG;

            Filmovi = FilmManager.GetFilmovi();

            koji = true;
            checkBoxFilmPoZelji.IsEnabled = false;

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            items.Clear();
            //itemsG.Clear();
            items.Add(new MyFlipViewItem
            {
                image1 = "/Assets/angryBirds.jpg",
                image2 = "/Assets/ourKindOfTraitor.jpg",
                image3 = "/Assets/captainAmerica.jpg",
                naslov1 = "Angry Birds film",
                naslov2 = "Izdajnik po našem ukusu",
                naslov3 = "Kapetan Amerika: Građanski rat"
            });
            items.Add(new MyFlipViewItem
            {
                image1 = "/Assets/mothersDay.jpg",
                image2 = "/Assets/ourKindOfTraitor.jpg",
                image3 = "/Assets/captainAmerica.jpg",
                naslov1 = "Majčin dan",
                naslov2 = "Izdajnik po našem ukusu",
                naslov3 = "Kapetan Amerika: Građanski rat"
            });

        }
        private void GridView_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Film film = ((Film)e.ClickedItem);
            this.Frame.Navigate(typeof(DetaljiRepertoar), film);

        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            koji = true;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            koji = false;
            checkBoxFilmPoZelji.IsEnabled = true;
        }

        private void gridViewPonuda_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void checkBoxFilmPoZelji_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UnosPodatakaZaPravnoLice));
        }

        private void buttonNazad_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pocetna));
        }
    }
}