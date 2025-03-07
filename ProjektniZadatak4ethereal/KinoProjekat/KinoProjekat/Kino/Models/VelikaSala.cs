﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekat.Kino.Models
{
    class VelikaSala : Sala
    {
        List<List<bool>> mjesta;
        int slobodnaMjesta;
        int velikaSalaId;

        public VelikaSala():base() { }
        public VelikaSala(bool zauzeta, List<List<bool>> mjesta, int slobodnaMjesta) 
            :base(zauzeta)
        {
            this.mjesta = mjesta;
            this.slobodnaMjesta = slobodnaMjesta;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VelikaSalaId { get; set; }
        public List<List<bool>> Mjesta { get; set; }
        public int SlobodnaMjesta { get; set; }

        public bool zauzmi(List<Tuple<int, int>> matrica)
        {

            return true;
        }

    }
}
