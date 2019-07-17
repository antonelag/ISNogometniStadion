using Microsoft.EntityFrameworkCore.Migrations;

namespace ISNogometniStadion.WebAPI.Migrations
{
    public partial class promjenaUlaznica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ulaznice_Utakmice_UtakmicaID",
                table: "Ulaznice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ulaznice",
                table: "Ulaznice");

            migrationBuilder.DropIndex(
                name: "IX_Ulaznice_UtakmicaID",
                table: "Ulaznice");

            migrationBuilder.AddColumn<int>(
                name: "UtakmicaID1",
                table: "Ulaznice",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "utakmicaDomaciTimID",
                table: "Ulaznice",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "utakmicaGostujuciTimID",
                table: "Ulaznice",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ulaznice",
                table: "Ulaznice",
                column: "UlaznicaID");

            migrationBuilder.CreateIndex(
                name: "IX_Ulaznice_UtakmicaID1_utakmicaDomaciTimID_utakmicaGostujuciTimID",
                table: "Ulaznice",
                columns: new[] { "UtakmicaID1", "utakmicaDomaciTimID", "utakmicaGostujuciTimID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Ulaznice_Utakmice_UtakmicaID1_utakmicaDomaciTimID_utakmicaGostujuciTimID",
                table: "Ulaznice",
                columns: new[] { "UtakmicaID1", "utakmicaDomaciTimID", "utakmicaGostujuciTimID" },
                principalTable: "Utakmice",
                principalColumns: new[] { "UtakmicaID", "DomaciTimID", "GostujuciTimID" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ulaznice_Utakmice_UtakmicaID1_utakmicaDomaciTimID_utakmicaGostujuciTimID",
                table: "Ulaznice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ulaznice",
                table: "Ulaznice");

            migrationBuilder.DropIndex(
                name: "IX_Ulaznice_UtakmicaID1_utakmicaDomaciTimID_utakmicaGostujuciTimID",
                table: "Ulaznice");

            migrationBuilder.DropColumn(
                name: "UtakmicaID1",
                table: "Ulaznice");

            migrationBuilder.DropColumn(
                name: "utakmicaDomaciTimID",
                table: "Ulaznice");

            migrationBuilder.DropColumn(
                name: "utakmicaGostujuciTimID",
                table: "Ulaznice");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ulaznice",
                table: "Ulaznice",
                columns: new[] { "UlaznicaID", "UtakmicaID", "SjedaloID" });

            migrationBuilder.CreateIndex(
                name: "IX_Ulaznice_UtakmicaID",
                table: "Ulaznice",
                column: "UtakmicaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ulaznice_Utakmice_UtakmicaID",
                table: "Ulaznice",
                column: "UtakmicaID",
                principalTable: "Utakmice",
                principalColumn: "UtakmicaID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
