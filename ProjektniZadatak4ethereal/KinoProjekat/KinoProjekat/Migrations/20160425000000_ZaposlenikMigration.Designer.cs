using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using KinoProjekat.Kino.Models;

namespace KinoProjekatMigrations
{
    [ContextType(typeof(ZaposlenikDbContext))]
    partial class ZaposlenikMigration
    {
        public override string Id
        {
            get { return "20160425000000_ZaposlenikMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("KinoProjekat.Kino.Models.Zaposlenik", b =>
                {
                    b.Property<int>("ZaposenikId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<int>("Uloga");

                    b.Key("ZaposenikId");
                });
        }
    }
}
