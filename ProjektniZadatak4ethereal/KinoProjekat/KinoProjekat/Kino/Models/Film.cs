using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekat.Kino.Models
{
   
    public class Film
    {
        String naziv, link, reziser, uloge, zanr, slika, orginalniNaslov, videoLink, opis;
        List<String> terminiPrikazivanja;
        List<Termin> termini;
        int filmId = 0;


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FilmId
        { get; set; }

        public List<String> TerminiPrikazivanja
        { get; set; }

        public String Opis
        { get; set; }

        public String Naziv
        { get; set; }

        public String VideoLink
        { get; set; }

        public String OrginalniNaziv
        { get; set; }

        public String Slika
        { get; set; }

        public String Link
        { get; set; }

        public String Reziser
        { get; set; }

        public String Uloge
        { get; set; }

        public String Zanr
        { get; set; }

        public List<Termin> Termini
        { get; set; }
    }
    public class FilmManager
    {
        public static List<Film> GetFilmovi()
        {
            var filmovi = new List<Film>();
            filmovi.Add(new Film
            {

                Slika = "ms-appx:///Assets/angryBirds1.jpg",
                Naziv = "Angry Birds film",
                OrginalniNaziv = "The Angry Birds Movie",
                Reziser = "Fergal Reilly",
                Uloge = "Jason Sudeikis, Josh Gad, Danny McBride",
                Zanr = "Animirana komedija",
                Opis = "U animniranoj 3D komediji Angry Birds Film konačno ćemo otkriti zbog čega su ptice toliko bijesne.Radnja filma vodi nas na otok nastanjen isključivo sretnim pticama – ili barem većinom njih. U ovom raju, Crveni (ptica s problematičnim temperamentom), ludi Chuck i nestabilni Bomba oduvijek su bili autsajderi. Ali kada otok posjete misteriozne zelene svinje, upravo će na ovu trojicu pasti zadatak otkriti zbog čega su novopridošlice posjetile baš njihovo područje",
                TerminiPrikazivanja= new List<string>(new string[] { "12:30", "15:30" }),
                Link = "http://www.imdb.com/title/tt1985949/",
                VideoLink = "https://www.youtube.com/embed/QRmKa7vvct4"
            });
            filmovi.Add(new Film
            {
                Slika = "ms-appx:///Assets/warcraft2.jpg",
                Naziv = "WARCRAFT: POČETAK 3D",
                OrginalniNaziv = "Warcraft",
                Opis = "Iz studija Legendary Pictures i Universal Pictures stiže Warcraft: Početak, epska avantura o sukobu nastalom zbog sudara svjetova zasnovana na svjetskom fenomenu Blizzard Entertainmenta. Mirno carstvo Azerota stoji na ivici rata kad se njihova civilizacija suoči sa neustrašivom rasom osvajača: Ork ratnici bježe iz svog doma koji je na rubu propasti i žele da kolonizuju drugi svijet. Kad se portal otvori da spoji ova dva svijeta, jedna vojska se suočava sa uništenjem, a druga sa nestankom. Sa ove dvije zaraćene strane, dva heroja će krenuti jedan na drugog, a to će odrediti sudbinu njihovih porodica, njihovog naroda i njihovog doma. Tako počinje spektakularna saga o moći i žrtvovanju u kojoj rat ima mnogo lica i gdje se svako bori za nešto...",
                Reziser = "Fergal Reilly",
                Uloge = "Travis Fimmel, Paula Patton, Ben Foster...",
                TerminiPrikazivanja = new List<string>(new string[] { "12:30", "15:30" }),
                Zanr = "Epska avantura",
                Link = "http://www.imdb.com/title/tt0803096/",
                VideoLink = "https://www.youtube.com/embed/2Rxoz13Bthc"
            });
            filmovi.Add(new Film
            {
                Slika = "ms-appx:///Assets/moneymonstersmall.jpg",
                Naziv = "Igra novca",
                OrginalniNaziv = " Money Monster",
                Opis = "Igra novca napeti je triler u kojem je glavni lik Lee Gates (Clooney), bombastični televizijski voditelj kojeg je njegova vlastita popularna emisija o financijama pretvorila u praktički čudotvorca Wall Streeta. Međutim nakon što svima preporuči kupnju visoko - tehnoloških dionica koje misteriozno propadnu, bijesni investitor (O Connell) dolazi u studio i uživo pred kamerama kao taoce uzima Gatesa i ekipu iza kamere predvođenu vrhunskom producenticom Patty Fenn (Roberts). Dok se sve odvija u pravom vremenu, Gates i Fenn moraju pronaći način kako preživjeti i istovremeno razotkriti istinu iza velike laži koju krije igra novca...",
                Reziser = " Jodie Foster",
                Uloge = "George Clooney, Julia Roberts, Jack O Connell...",
                TerminiPrikazivanja = new List<string>(new string[] { "16:40", "18:40" }),
                Zanr = "Triler, drama",
                Link = "http://www.imdb.com/title/tt2241351/",
                VideoLink = "https://www.youtube.com/embed/qr_nGAbFkmk"
            });
            filmovi.Add(new Film
            {
                Slika = "ms-appx:///Assets/Alice3.jpg",
                Naziv = "Alisa iza ogledala",
                OrginalniNaziv = "Alice Through the Looking Glas",
                Opis = "Alisa iza ogledala nova je spektakularna pustolovina Tim Burtona koja ponovno okuplja zvjezdanu glumačku ekipu Johnny Deppa, Anne Hathaway, Miju Wasikowsku i Helenu Bonham Carter. U ovom nastavku Alisa se vraća u Zemlju čudesa kako bi spasila ludog Klobučara. Na svom putovanju, Alisa susreće Vrijeme, Crvenu kraljicu i ostale likove, a hoće li imati vremena za čaj provjerite 26.5. u svim kinima...",
                Reziser = "James Bobin",
                Uloge = "Johnny Depp, Sacha Baron Cohen, Anne Hathaway...",
                TerminiPrikazivanja = new List<string>(new string[] { "16:25", "18:45" }),
                Zanr = "Avantura, obiteljski, fantazija",
                Link = "http://www.imdb.com/title/tt2567026/",
                VideoLink = "https://www.youtube.com/embed/I3PTtSsnHpI"
            });
            filmovi.Add(new Film
            {
                Slika = "ms-appx:///Assets/Man2.jpg",
                Naziv = "Čovjek koji je spoznao vječnost",
                OrginalniNaziv = "The Man who knew infinity",
                Opis = "Srinivasa Ramanujan živio je od 1887. do 1920. godine i dao je velik doprinos matematičkom svijetu, bez da je imao ikakvu matematičku naobrazbu. Ramanujan (Dev Patel), samouki indijski matematičar 1913. godine putuje na fakultet Trinity na Cambridgu, gdje upoznaje ekscentričnog profesora G.H. Hardyja (Jeremy Irons), i bori se s predrasudama kako bi otkrio svoju matematičku genijalnost. Ramanujana neki stavljaju u istu kategoriju s Eulerom i Gaussom, a Indija je njemu u čast 22.12. (njegov rođendan) proglasila Nacionalnim danom matematike...",
                Reziser = "Matt Brown",
                Uloge = " Jeremy Irons, Dev Patel, Stephen Fry...",
                TerminiPrikazivanja = new List<string>(new string[] { "16:25", "18:45" }),
                Zanr = "Drama, biografski",
                Link = "http://www.imdb.com/title/tt0787524/",
                VideoLink = "https://www.youtube.com/embed/oXGm9Vlfx4w"
            });
            filmovi.Add(new Film
            {
                Slika = "ms-appx:///Assets/apok2.jpg",
                Naziv = "Samo najjači opstaju",
                OrginalniNaziv = " X-Men: Apocalypse ",
                Opis = "Deveti po redu film iz Marvelovog mutantskog svijeta. Glavni negativac u novom nastavku je Apocalypse, kojega je utjelovio Oscar Isaac. Nakon tisućljetnog sna budi se i formira tim snažnih mutanata, u­ključujući i Magneta kojeg tumači Michael Fassbender. Oni žele pročistiti čovječanstvo i stvoriti novi svjetski poredak, u kojem će vladati Apocalypse. Kako je sudbina Zemlje ugrožena, Raven ( Jennifer Lawrence ), uz pomoć profesora X ( James McAvoy ) mora voditi tim koji će zaustaviti njihovog najvećeg neprijatelja i spasiti čovječanstvo od potpunog uništenja...",
                Reziser = "Bryan Singer",
                Uloge = "Jennifer Lawrence, Michael Fassbender, Oscar Isaac...",
                TerminiPrikazivanja = new List<string>(new string[] { "17:20", "19:00" }),
                Zanr = "Akcija, avantura, fantazija",
                Link = "http://www.imdb.com/title/tt3385516/",
                VideoLink = "https://www.youtube.com/embed/Jer8XjMrUB4"
            });
            filmovi.Add(new Film
            {
                Slika = "ms-appx:///Assets/jungle2.jpg",
                Naziv = "Knjiga o džungli",
                OrginalniNaziv = "The Jungle Book",
                Opis = "Knjiga o džungli slijedi original iz 1967. kojeg i danas mnogi smatraju jednim od najboljih Disneyevih filmova. Zapanjujuća realna animacija i oskarovska glumačka ekipa na spektakularan način oživljava epsku Kiplingovu priču o dječačiću Mowgliju kojeg je odgojila obitelj vukova i koji uz pomoć prijatelja pantere Bagheere i medvjeda Balooa, pobjeđuje kralja džungle opasnog tigra ShereKhana. Knjiga o džungli priča je o prijateljstvu, ljubavi, odanosti i hrabrosti ...",
                Reziser = "Jon Favreau",
                Uloge = " Scarlett Johansson, Idris Elba, Christopher Walken...",
                TerminiPrikazivanja = new List<string>(new string[] { "17:20", "19:00" }),
                Zanr = "Porodična avantura",
                Link = "http://www.imdb.com/title/tt3040964/",
                VideoLink = "https://www.youtube.com/embed/5mkm22yO-bs"
            });
            filmovi.Add(new Film
            {
                Slika = "ms-appx:///Assets/komsije.jpg",
                Naziv = "Loše komšije 2",
                OrginalniNaziv = "Neighbors 2: Sorority Rising",
                Opis = "Zvijezdama iz prvog dijela: Seth Rogenu, Zac Efronu i Rose Byrne, pridružuje se Chloë Grace Moretz u filmu „Loše komšije 2“, nastavku najpopularnije originalne komedije iz 2014. Nicholas Stoller ponovo režira film o tome šta se desi kad se roditeljska volja usmjeri protiv bliskosti sestrinstva.Sad Mac(Rogen) i Kelly Radner(Byrne) treba da dobiju drugo dijete i spremni su da naprave konačni prijelaz ka zrelom životu: da se presele u predgrađe.Ali taman kad su pomislili da su povratili komšiluk u svoje ruke i da je bezbjedno da prodaju kuću,shvataju da se do njih doselilo sestrinstvo, koje je još luđe od Teddya (Efron)i njegovog bratstva...",
                Reziser = "Nicholas Stoller",
                Uloge = "Seth Rogen, Zac Efron, Rose Byrne...",
                TerminiPrikazivanja = new List<string>(new string[] { "17:20", "19:00" }),
                Zanr = " Komedija",
                Link = "http://www.imdb.com/title/tt4438848/",
                VideoLink = "https://www.youtube.com/embed/P5dTHmlq9r8"
            });
            filmovi.Add(new Film
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
            });
            filmovi.Add(new Film
            {
                Slika = "ms-appx:///Assets/nice.png",
                Naziv = "Dobri Momci",
                OrginalniNaziv = "The Nice guys",
                Opis = "Dobri momci je nadolazeći triler režiran od strane Shanea Blacka. U glavnim ulogama su Russell Crowe, Ryan Gosling, Angourie Rice, Matt Bomer, Margaret Qualley, Keith David i Kim Basinger. Privatni detektiv Holland March (Ryan Gosling) i unajmljeni iznuđivač Jackson Healy (Russell Crowe) primorani su raditi zajedno kako bi riješili slučaj nestale djevojke i njene povezanosti sa smrću porno zvijezde. Tijekom istrage otkrivaju šokantnu urotu koja seže do najviših krugova moći...",
                Reziser = "Shane Black ",
                Uloge = "Ryan Gosling, Russell Crowe, Matt Bomer...",
                TerminiPrikazivanja = new List<string>(new string[] { "13:20", "12:00" }),
                Zanr = "Triler",
                Link = "http://www.imdb.com/title/tt3799694/",
                VideoLink = "https://www.youtube.com/embed/GQR5zsLHbYw"
            });
            return filmovi;
        }
    }
}
