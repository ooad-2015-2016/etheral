using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace KinoProjekatMigrations
{
    public partial class Sala : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Sala",
                columns: table => new
                {
                    SalaId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Zauzeta = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sala", x => x.SalaId);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Sala");
        }
    }
}
