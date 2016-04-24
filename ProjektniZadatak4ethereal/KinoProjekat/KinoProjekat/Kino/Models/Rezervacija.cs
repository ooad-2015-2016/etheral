using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KinoProjekat.Kino.Models
{
    enum NacinPlacanja { Gotovina, Kartica, TransakcijskiRacun };
    enum StatusRezervacije { Nepotvrdjena, Potvrdjena, Otkazana };

    class Rezervacija
    {
        int brojRezervacije = 0;
        NacinPlacanja placanje;
        StatusRezervacije status;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int BrojRezervacije { get; set; }
        public NacinPlacanja Placanje { get; set; }
        public StatusRezervacije Status { get; set; }
    }
}
