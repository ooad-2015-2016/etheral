using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
    public sealed partial class Sala : Page
    {
        public Sala()
        {
            this.InitializeComponent();
        }

        private void buttonName_Click(object sender, RoutedEventArgs e)
        {
            //u ovisnosti sta je bilo fira ili PRavno ili fizicko
            this.Frame.Navigate(typeof(UnosPodatakaZaFizickoLice));
            //this.Frame.Navigate(typeof(UnosPodatakaZaPravnoLice));
        }

        private void Dalje_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ZavrsnaForma));

        }

        private void s1_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            SolidColorBrush nasaBoja =(SolidColorBrush) s1.Background;
            if (nasaBoja.Color == Colors.WhiteSmoke)
                s1.Background = new SolidColorBrush(Colors.DarkSeaGreen);
            else if (nasaBoja.Color == Colors.DarkSeaGreen)
                s1.Background = new SolidColorBrush(Colors.WhiteSmoke);
        }

        private void s2_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            SolidColorBrush nasaBoja = (SolidColorBrush)s2.Background;
            if (nasaBoja.Color == Colors.WhiteSmoke)
                s2.Background = new SolidColorBrush(Colors.DarkSeaGreen);
            else if (nasaBoja.Color == Colors.DarkSeaGreen)
                s2.Background = new SolidColorBrush(Colors.WhiteSmoke);

        }
    }
}
