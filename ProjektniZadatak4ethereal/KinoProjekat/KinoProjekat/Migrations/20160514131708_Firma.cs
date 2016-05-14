using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace KinoProjekatMigrations
{
    public partial class Firma : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Firma",
                columns: table => new
                {
                    FirmaId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Adresa = table.Column(type: "TEXT", nullable: true),
                    Naziv = table.Column(type: "TEXT", nullable: true),
                    TransakcijskiRacun = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firma", x => x.FirmaId);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Firma");
        }
    }
}
