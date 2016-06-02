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

                    b.Property<string>("Opis");

                    b.Property<string>("OrginalniNaziv");

                    b.Property<string>("Reziser");

                    b.Property<string>("Slika");

                    b.Property<string>("Uloge");

                    b.Property<string>("VideoLink");

                    b.Property<string>("Zanr");

                    b.Key("FilmId");
                });

            builder.Entity("KinoProjekat.Kino.Models.Termin", b =>
                {
                    b.Property<DateTime>("Datum")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("FilmFilmId");

                    b.Property<int>("TerminId");

                    b.Property<DateTime>("VrijemePocetka");

                    b.Property<DateTime>("VrijemeZavrsetka");

                    b.Property<int>("ZauzetaMjesta");

                    b.Key("Datum");
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
