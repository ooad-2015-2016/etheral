using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace KinoProjekatMigrations
{
    public partial class FilmMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Film",
                columns: table => new
                {
                    FilmId = table.Column(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Link = table.Column(type: "TEXT", nullable: true),
                    Naziv = table.Column(type: "TEXT", nullable: true),
                    Reziser = table.Column(type: "TEXT", nullable: true),
                    Uloge = table.Column(type: "TEXT", nullable: true),
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
                    BrojTermina = table.Column(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FilmFilmId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termin", x => x.BrojTermina);
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
