using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekat.Kino.Models
{
    class DefaultPodaci
    {

        public static void Initialize(LiceDbContext context)
        {
            if (!context.Lice.Any())
            {
                context.Lice.AddRange(
                new Lice()
                {
                    Ime="Niko",
                    Prezime="Nikic",
                    Telefon="066666666",
                    Email="niko@hotmail.com",                    
                }
                );
                context.SaveChanges();
            }
        }
    }

}
