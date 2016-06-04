using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekat.Kino.Models
{
    class DefaultPodaciFilm
    {
        public static void Initialize(FilmDbContext context)
        {
            if (!context.SviFilmovi.Any())
            {
                context.SviFilmovi.AddRange(
                new Film()
                {
                    Slika = "ms-appx:///Assets/cat.jpg",
                    Naziv = "Top Cat",
                    OrginalniNaziv = "Don Gato: El Inicio de la Pandilla",
                    Opis = "Top Cat sebični je mačak koji ne vjeruje nikome. Iako sanja o velikom bogatstvu jedva si može prisutiti jedno jelo na dan.Jednog dana upozna Peru Petlju,naivnoga i dobroćudnog mačka koji je očaran Top Catom.Oni postaju partneri i zajedno varaju ljude.Odluče pokrasti Velikog šefa, misterioznog lika koji vlada gradom.Pero i Top Cat pripreme zamku kako bi opljačkali dijamante Velikog šefa koje je i ovaj sam pokrao.Iako uspiju u svome naumu to je tek početak njihovih problema.Pero Petlja sakrije dijamante u stanu svoje mame koje kasnije ne može pronaći...",
                    Reziser = " Andres Couturier",
                    Uloge = "Dražen Bratulić, Ronald Žlabur, Željko Šestić",
                    TerminiPrikazivanja = new List<string>(new string[] { "14:20", "14:00" }),
                    Zanr = " Animirani, pustolovni",
                    Link = "http://www.imdb.com/title/tt4057916/",
                    VideoLink = "https://www.youtube.com/embed/pyFKDVuMOLE"
                }
                );
                context.SaveChanges();
            }
        }
    }

}
