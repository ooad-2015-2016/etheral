using KinoProjekat.Kino.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class OdabirFilma : Page
    {
        public bool koji;
        private bool samoRepertoar = true;
        private ObservableCollection<MyFlipViewItem> items;
        //private ObservableCollection<MyGridViewItem> itemsG;
        private List<Film> Filmovi;
        public OdabirFilma()
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
            var repertoar = e.Parameter;
            samoRepertoar = (bool)repertoar;
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
            /*items.Add(new MyFlipViewItem { image1 = "/Assets/angryBirds.jpg", image2 = "/Assets/ourKindOfTraitor.jpg", image3 = "/Assets/captainAmerica.jpg",
                naslov1 = "Angry Birds film", naslov2 = "Izdajnik po našem ukusu", naslov3 = "Kapetan Amerika: Građanski rat" });*/
            /*items.Add(new MyFlipViewItem { image1 = "/Assets/angryBirds.jpg", image2 = "/Assets/ourKindOfTraitor.jpg", image3 = "/Assets/captainAmerica.jpg" });
            items.Add(new MyFlipViewItem { image1 = "/Assets/angryBirds.jpg", image2 = "/Assets/ourKindOfTraitor.jpg", image3 = "/Assets/captainAmerica.jpg" });*/
            /*itemsG.Add(new MyGridViewItem { image = "/Assets/angryBirds1.jpg", naslov = "Angry Birds film", originalniNaslov = "The Angry Birds Movie",
            reziser = "Fergal Reilly", uloge = "Jason Sudeikis, Josh Gad, Danny McBride", zanr = "Animirana komedija", link = "http://www.imdb.com/title/tt1985949/"});*/

            Frame rootFrame = Window.Current.Content as Frame;

            string myPages = "";
            foreach (PageStackEntry page in rootFrame.BackStack)
            {
                myPages += page.SourcePageType.ToString() + "\n";
            }
            //stackCount.Text = myPages;

            if (rootFrame.CanGoBack)
            {
                // Show UI in title bar if opted-in and in-app backstack is not empty.
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                    AppViewBackButtonVisibility.Visible;

                SystemNavigationManager.GetForCurrentView().BackRequested += OdabirFilma_BackRequested;
            }
            else
            {
                // Remove the UI from the title bar if in-app back stack is empty.
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                    AppViewBackButtonVisibility.Collapsed;
            }

        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().BackRequested -= OdabirFilma_BackRequested;
        }

        private void OdabirFilma_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if (this.Frame.CanGoBack) this.Frame.GoBack();
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

        private void GridView_ItemClick_11(object sender, ItemClickEventArgs e)
        {
            Film film = ((Film)e.ClickedItem);
            this.Frame.Navigate(typeof(Detalji), film);
        }

        /*private void buttonNazad_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pocetna));
        }*/
    }
}
