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
    class LiceDbContext : DbContext
    {
        public DbSet<Lice> Lice{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dataBaseFilePath = "BazaZaLice.db";
            try
            {
                dataBaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, dataBaseFilePath);
            }
            catch (InvalidOperationException) { }

            optionsBuilder.UseSqlite($"Data source={dataBaseFilePath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // jedno od polja je image da se zna šta je zapravo predstavlja byte[]
            // modelBuilder.Entity<Restoran>().Property(p => p.Slika).HasColumnType("image");
        }
    }

}