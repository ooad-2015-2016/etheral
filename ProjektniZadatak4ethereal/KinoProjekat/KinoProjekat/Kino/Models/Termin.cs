using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekat.Kino.Models
{
    public class Termin
    {
        DateTime datum, vrijemePocetka, vrijemeZavrsetka;
        int zauzetaMjesta;
        int terminId;

        public Termin() { }
        public Termin(DateTime datum, DateTime vrijemePocetka, DateTime vrijemeZavrsetka, int zauzetaMjesta)
        {
            this.datum = datum;
            this.vrijemePocetka = vrijemePocetka;
            this.vrijemeZavrsetka = vrijemeZavrsetka;
            this.zauzetaMjesta = zauzetaMjesta;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public DateTime Datum { get; set; }
        public DateTime VrijemePocetka { get; set; }
        public DateTime VrijemeZavrsetka { get; set; }
        public int ZauzetaMjesta { get; set; }
        public int TerminId { get; set; }

    }
}
