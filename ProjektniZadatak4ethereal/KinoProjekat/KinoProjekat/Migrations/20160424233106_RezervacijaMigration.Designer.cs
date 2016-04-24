using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using KinoProjekat.Kino.Models;

namespace KinoProjekatMigrations
{
    [ContextType(typeof(RezervacijaDbContext))]
    partial class RezervacijaMigration
    {
        public override string Id
        {
            get { return "20160424233106_RezervacijaMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
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
