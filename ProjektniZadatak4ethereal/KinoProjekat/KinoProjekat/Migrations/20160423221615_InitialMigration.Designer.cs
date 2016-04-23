using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using KinoProjekat.Kino.Models;

namespace KinoProjekatMigrations
{
    [ContextType(typeof(LiceDbContext))]
    partial class InitialMigration
    {
        public override string Id
        {
            get { return "20160423221615_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("KinoProjekat.Kino.Models.Lice", b =>
                {
                    b.Property<int>("LiceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<string>("Email");

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<string>("Telefon");

                    b.Key("LiceId");
                });
        }
    }
}
