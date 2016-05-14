using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using KinoProjekat.Kino.Models;

namespace KinoProjekatMigrations
{
    [ContextType(typeof(SalaDbContext))]
    partial class Sala
    {
        public override string Id
        {
            get { return "20160514123428_Sala"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("KinoProjekat.Kino.Models.Sala", b =>
                {
                    b.Property<int>("SalaId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Zauzeta");

                    b.Key("SalaId");
                });
        }
    }
}
