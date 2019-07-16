using Microsoft.EntityFrameworkCore.Migrations;

namespace ISNogometniStadion.WebAPI.Migrations
{
    public partial class dodatakKorisnicima : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Korisnici",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "korisnickoIme",
                table: "Korisnici",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lozinka",
                table: "Korisnici",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "telefon",
                table: "Korisnici",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "Korisnici");

            migrationBuilder.DropColumn(
                name: "korisnickoIme",
                table: "Korisnici");

            migrationBuilder.DropColumn(
                name: "lozinka",
                table: "Korisnici");

            migrationBuilder.DropColumn(
                name: "telefon",
                table: "Korisnici");
        }
    }
}
