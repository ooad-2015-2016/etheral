using System;
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
        string ime, prezime;
        TipZaposlenika uloga;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZaposenikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public TipZaposlenika Uloga { get; set; }

    }
}
