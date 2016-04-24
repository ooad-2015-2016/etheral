using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using KinoProjekat.Kino.Models;

namespace KinoProjekatMigrations
{
    [ContextType(typeof(RezervacijaDbContext))]
    partial class RezervacijaDbContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("KinoProjekat.Kino.Models.Rezervacija", b =>
                {
                    b.Property<int>("BrojRezervacije")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Placanje");

                    b.Property<int>("Status");

                    b.Key("BrojRezervacije");
                });
        }
    }
}
