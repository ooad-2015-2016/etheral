using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using KinoProjekat.Kino.Models;

namespace KinoProjekatMigrations
{
    [ContextType(typeof(LiceDbContext))]
    partial class LiceeMigration
    {
        public override string Id
        {
            get { return "20160604104435_LiceeMigration"; }
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

                    b.Property<string>("Email");

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<string>("Telefon");

                    b.Key("LiceId");
                });
        }
    }
}
