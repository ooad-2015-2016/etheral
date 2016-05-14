using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using KinoProjekat.Kino.Models;

namespace KinoProjekatMigrations
{
    [ContextType(typeof(SalaDbContext))]
    partial class SalaDbContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
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
