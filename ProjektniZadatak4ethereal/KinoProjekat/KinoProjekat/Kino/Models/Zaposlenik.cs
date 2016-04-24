﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace KinoProjekat.Kino.Models
{
    enum TipZaposlenika { RadnikNaSalteru, AdministratorSistema};
    class Zaposlenik
    {
        string imeZ, prezimeZ;
        TipZaposlenika ulogaZ;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int zaposenikId { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public TipZaposlenika uloga { get; set; }

    }
}
