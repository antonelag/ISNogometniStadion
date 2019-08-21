using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ISNogometniStadion.WebAPI.Migrations
{
    public partial class slikeStadioni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Slika",
                table: "Stadioni",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "SlikaThumb",
                table: "Stadioni",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Stadioni");

            migrationBuilder.DropColumn(
                name: "SlikaThumb",
                table: "Stadioni");
        }
    }
}
