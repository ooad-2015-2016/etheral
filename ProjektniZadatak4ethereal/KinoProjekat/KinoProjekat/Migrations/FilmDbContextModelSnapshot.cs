using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using KinoProjekat.Kino.Models;

namespace KinoProjekatMigrations
{
    [ContextType(typeof(FilmDbContext))]
    partial class FilmDbContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("KinoProjekat.Kino.Models.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Link");

                    b.Property<string>("Naziv");

                    b.Property<string>("Reziser");

                    b.Property<string>("Uloge");

                    b.Property<string>("Zanr");

                    b.Key("FilmId");
                });

            builder.Entity("KinoProjekat.Kino.Models.Termin", b =>
                {
                    b.Property<int>("BrojTermina")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("FilmFilmId");

                    b.Key("BrojTermina");
                });

            builder.Entity("KinoProjekat.Kino.Models.Termin", b =>
                {
                    b.Reference("KinoProjekat.Kino.Models.Film")
                        .InverseCollection()
                        .ForeignKey("FilmFilmId");
                });
        }
    }
}
