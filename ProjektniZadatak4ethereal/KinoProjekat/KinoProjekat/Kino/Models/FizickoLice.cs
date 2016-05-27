using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekat.Kino.Models
{
    enum StatusFizickogLica { dijete, ucenik, student, penzioner}
    enum TipKorisnika { SalterKorisnik, InternetKorisnik}
    class FizickoLice : Lice
    {
        StatusFizickogLica status;
        int fizickoLiceId;
        TipKorisnika tip;

        public FizickoLice() : base() { }
        public FizickoLice(string ime, string prezime, string telefon, string email, string adresa, StatusFizickogLica status, TipKorisnika tip)
            : base(ime, prezime, telefon, email)
        {
            this.status = status;
            this.tip = tip;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public StatusFizickogLica Status { get; set; }
        public int FizickoLiceId { get; set; }
        public TipKorisnika Tip { get; set; }  
    }
}
