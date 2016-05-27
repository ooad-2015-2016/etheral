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
    public sealed partial class OdabirFilma : Page
    {
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
            /*items.Add(new MyFlipViewItem { image1 = "/Assets/angryBirds.jpg", image2 = "/Assets/ourKindOfTraitor.jpg", image3 = "/Assets/captainAmerica.jpg",
                naslov1 = "Angry Birds film", naslov2 = "Izdajnik po našem ukusu", naslov3 = "Kapetan Amerika: Građanski rat" });*/
            /*items.Add(new MyFlipViewItem { image1 = "/Assets/angryBirds.jpg", image2 = "/Assets/ourKindOfTraitor.jpg", image3 = "/Assets/captainAmerica.jpg" });
            items.Add(new MyFlipViewItem { image1 = "/Assets/angryBirds.jpg", image2 = "/Assets/ourKindOfTraitor.jpg", image3 = "/Assets/captainAmerica.jpg" });*/
            /*itemsG.Add(new MyGridViewItem { image = "/Assets/angryBirds1.jpg", naslov = "Angry Birds film", originalniNaslov = "The Angry Birds Movie",
            reziser = "Fergal Reilly", uloge = "Jason Sudeikis, Josh Gad, Danny McBride", zanr = "Animirana komedija", link = "http://www.imdb.com/title/tt1985949/"});*/


        }
    }
}
