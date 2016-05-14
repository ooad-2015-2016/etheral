using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekat.Kino.Models
{
    abstract class Sala
    {
        bool zauzeta;
        int salaId;

        public Sala(bool zauzeta)
        {
            this.zauzeta = zauzeta;
        }

        public Sala(){}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalaId { get; set; }
        public bool Zauzeta { get; set; }     

        
    }
}
