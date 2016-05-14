using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekat.Kino.Models
{
    class SrednjaSala : Sala
    {
        List<List<bool>> mjesta;
        int slobodnaMjesta;
        int srednjaSalaId;

        public SrednjaSala():base() { }
        public SrednjaSala(bool zauzeta, List<List<bool>> mjesta, int slobodnaMjesta) 
            :base(zauzeta)
        {
            this.mjesta = mjesta;
            this.slobodnaMjesta = slobodnaMjesta;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SrednjaSalaId { get; set; }
        public List<List<bool>> Mjesta { get; set; }
        public int SlobodnaMjesta { get; set; }
    }
}
