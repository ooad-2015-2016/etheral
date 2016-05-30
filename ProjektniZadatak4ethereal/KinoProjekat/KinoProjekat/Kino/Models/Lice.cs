using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekat.Kino.Models
{
    public class Lice
    {
        public Lice(String ime, String prezime, String telefon, String email)
        {
            Ime = ime;
            Prezime = prezime;
            Telefon = telefon;
            Email = email;

        }

        public Lice() {}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LiceId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
       

    }
}
