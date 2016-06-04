using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System.IO;
using Windows.Storage;

namespace KinoProjekat.Kino.Models
{
    class RezervacijaDbContext : DbContext
    {
        public DbSet<Rezervacija> SveRezervacije { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dataBaseFilePath = "BazaZaRezervacije.db";
            try
            {
                dataBaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, dataBaseFilePath);
            }
            catch (InvalidOperationException) { }

            optionsBuilder.UseSqlite($"Data source={dataBaseFilePath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // lel ništa
        }
    }
}
