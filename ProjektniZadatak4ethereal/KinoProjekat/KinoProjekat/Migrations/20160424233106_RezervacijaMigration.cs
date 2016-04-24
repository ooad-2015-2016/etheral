using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace KinoProjekatMigrations
{
    public partial class RezervacijaMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    BrojRezervacije = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Placanje = table.Column(type: "INTEGER", nullable: false),
                    Status = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.BrojRezervacije);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Rezervacija");
        }
    }
}
