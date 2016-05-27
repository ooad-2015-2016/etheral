using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekat.Kino.Views
{
    public class Film
    {
        public string image { get; set; }
        public string naslov { get; set; }
        public string originalniNaslov { get; set; }
        public string reziser { get; set; }
        public string uloge { get; set; }
        public string zanr { get; set; }
        public string link { get; set; }
    }

    public class FilmManager
    {
        public static List<Film> GetFilmovi()
        {
            var filmovi = new List<Film>();
            filmovi.Add(new Film
            {
                image = "/Assets/angryBirds1.jpg",
                naslov = "Angry Birds film",
                originalniNaslov = "The Angry Birds Movie",
                reziser = "Fergal Reilly",
                uloge = "Jason Sudeikis, Josh Gad, Danny McBride",
                zanr = "Animirana komedija",
                link = "http://www.imdb.com/title/tt1985949/"
            });

            filmovi.Add(new Film
            {
                image = "/Assets/angryBirds1.jpg",
                naslov = "Angry Birds film",
                originalniNaslov = "The Angry Birds Movie",
                reziser = "Fergal Reilly",
                uloge = "Jason Sudeikis, Josh Gad, Danny McBride",
                zanr = "Animirana komedija",
                link = "http://www.imdb.com/title/tt1985949/"
            });

            return filmovi;
        }
    }
}
