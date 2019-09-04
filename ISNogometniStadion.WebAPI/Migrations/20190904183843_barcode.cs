using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ISNogometniStadion.WebAPI.Migrations
{
    public partial class barcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "barcodeimg",
                table: "Ulaznice",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "barcodeimg",
                table: "Ulaznice");
        }
    }
}
