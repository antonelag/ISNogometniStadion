using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ISNogometniStadion.WebAPI.Migrations
{
    public partial class utakmicaslika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Slika",
                table: "Utakmice",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "SlikaThumb",
                table: "Utakmice",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Utakmice");

            migrationBuilder.DropColumn(
                name: "SlikaThumb",
                table: "Utakmice");
        }
    }
}
