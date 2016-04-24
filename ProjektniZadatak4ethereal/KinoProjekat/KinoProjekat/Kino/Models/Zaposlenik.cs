using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekat.Kino.Models
{
    enum TipZaposlenika { RadnikNaSalteru, AdministratorSistema};
    class Zaposlenik
    {
        string ime, prezime;
        TipZaposlenika uloga;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZaposenikId { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public TipZaposlenika uloga { get; set; }

    }
}
