using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using KinoProjekat.Kino.Models;

namespace KinoProjekatMigrations
{
    [ContextType(typeof(FirmaDbContext))]
    partial class Firma
    {
        public override string Id
        {
            get { return "20160514131708_Firma"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("KinoProjekat.Kino.Models.Firma", b =>
                {
                    b.Property<int>("FirmaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<string>("Naziv");

                    b.Property<string>("TransakcijskiRacun");

                    b.Key("FirmaId");
                });
        }
    }
}
