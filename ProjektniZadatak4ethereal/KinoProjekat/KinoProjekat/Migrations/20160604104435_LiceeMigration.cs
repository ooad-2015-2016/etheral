using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace KinoProjekatMigrations
{
    public partial class LiceeMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Lice",
                columns: table => new
                {
                    LiceId = table.Column(type: "INTEGER", nullable: false)
                      ,//  .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column(type: "TEXT", nullable: true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Telefon = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lice", x => x.LiceId);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Lice");
        }
    }
}
