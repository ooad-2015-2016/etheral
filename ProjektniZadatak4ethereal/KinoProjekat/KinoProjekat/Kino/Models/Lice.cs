using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekat.Kino.Models
{
    class Lice
    {
        public Lice(string ime, string prezime, string telefon, string email, string adresa)
        {
            Ime = ime;
            Prezime = prezime;
            Telefon = telefon;
            Email = email;
            Adresa = adresa;
        }

        public Lice() {}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LiceId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }

    }
}
