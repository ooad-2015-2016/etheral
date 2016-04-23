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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LiceId { get; set; }//primary key u bazi
        public string Ime { get; set; }//trebati ce za sihronizaciju kasnije
        public string Prezime { get; set; }//naziv restorana
        public string Telefon { get; set; }//tekst o restoranu
        public string Email { get; set; }//broj telefona
        public string Adresa { get; set; }
    }
}
