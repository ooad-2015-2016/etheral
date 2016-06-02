using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace KinoProjekatMigrations
{
    public partial class FiilmMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Film",
                columns: table => new
                {
                    FilmId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Link = table.Column(type: "TEXT", nullable: true),
                    Naziv = table.Column(type: "TEXT", nullable: true),
                    Opis = table.Column(type: "TEXT", nullable: true),
                    OrginalniNaziv = table.Column(type: "TEXT", nullable: true),
                    Reziser = table.Column(type: "TEXT", nullable: true),
                    Slika = table.Column(type: "TEXT", nullable: true),
                    Uloge = table.Column(type: "TEXT", nullable: true),
                    VideoLink = table.Column(type: "TEXT", nullable: true),
                    Zanr = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.FilmId);
                });
            migration.CreateTable(
                name: "Termin",
                columns: table => new
                {
                    Datum = table.Column(type: "TEXT", nullable: false),
                    FilmFilmId = table.Column(type: "INTEGER", nullable: true),
                    TerminId = table.Column(type: "INTEGER", nullable: false),
                    VrijemePocetka = table.Column(type: "TEXT", nullable: false),
                    VrijemeZavrsetka = table.Column(type: "TEXT", nullable: false),
                    ZauzetaMjesta = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termin", x => x.Datum);
                    table.ForeignKey(
                        name: "FK_Termin_Film_FilmFilmId",
                        columns: x => x.FilmFilmId,
                        referencedTable: "Film",
                        referencedColumn: "FilmId");
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Termin");
            migration.DropTable("Film");
        }
    }
}
