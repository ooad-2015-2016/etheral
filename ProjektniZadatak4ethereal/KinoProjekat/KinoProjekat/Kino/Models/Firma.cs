using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekat.Kino.Models
{
    class Firma
    {
        String naziv, adresa, transakkcijskiRacun;
        int firmaId;

        public Firma() { }
        public Firma(String naziv, String adresa, String transakkcijskiRacun)
        {
            this.naziv = naziv;
            this.adresa = adresa;
            this.transakkcijskiRacun = transakkcijskiRacun;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FirmaId { get; set; }
        public String Naziv { get; set; }
        public String Adresa { get; set; }
        public String TransakcijskiRacun { get; set; }        
    }
}
