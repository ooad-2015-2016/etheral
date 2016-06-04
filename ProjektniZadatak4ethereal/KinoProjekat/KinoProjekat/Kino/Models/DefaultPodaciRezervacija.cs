using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekat.Kino.Models
{
    class DefaultPodaciRezervacija
    {

        /*
        
             public Rezervacija(int brojRezervacije,NacinPlacanja placanje,StatusRezervacije status)
         
        {
            this.brojRezervacije = brojRezervacije;
            this.placanje = placanje;
            this.status = status;
        }*/
        public static void Initialize(RezervacijaDbContext context)
        {
            if (!context.SveRezervacije.Any())
            {
                context.SveRezervacije.AddRange(
                new Rezervacija()
                {
                    BrojRezervacije = 1,
                    Placanje = NacinPlacanja.Gotovina,
                    Status=StatusRezervacije.Potvrdjena
                }
                );
                context.SaveChanges();
            }
        }
    }

}
