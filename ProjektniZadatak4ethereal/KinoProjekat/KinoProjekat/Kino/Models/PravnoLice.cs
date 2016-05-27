using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekat.Kino.Models
{
    class PravnoLice : Lice
    {
        Firma firma;
        String brojLicneKarte;
        int pravnoLiceId;

        public PravnoLice() : base() { }
        public PravnoLice(String ime, String prezime, String telefon, String email, Firma firma, String brojLicneKarte)
          : base(ime, prezime, telefon, email)
        {
            this.firma = firma;
            this.brojLicneKarte = brojLicneKarte;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PravnoLiceId { get; set; }
        public Firma Firma  { get; set; }
        public String BrojLicneKarte { get; set; }

        
    }
}
