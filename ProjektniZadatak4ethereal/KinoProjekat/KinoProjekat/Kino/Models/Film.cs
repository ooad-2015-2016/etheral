using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekat.Kino.Models
{
    class Film
    {
        String naziv, link, reziser, uloge, zanr;
        List<Termin> termini;
        int filmId = 0;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FilmId
        { get; set; }

        public String Naziv
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
}
