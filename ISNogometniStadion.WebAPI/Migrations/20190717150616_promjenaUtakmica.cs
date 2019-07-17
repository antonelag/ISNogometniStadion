using Microsoft.EntityFrameworkCore.Migrations;

namespace ISNogometniStadion.WebAPI.Migrations
{
    public partial class promjenaUtakmica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ulaznice_Utakmice_UtakmicaID1_utakmicaDomaciTimID_utakmicaGostujuciTimID",
                table: "Ulaznice");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Utakmice_UtakmicaID",
                table: "Utakmice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Utakmice",
                table: "Utakmice");

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
                name: "PK_Utakmice",
                table: "Utakmice",
                column: "UtakmicaID");

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
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ulaznice_Utakmice_UtakmicaID",
                table: "Ulaznice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Utakmice",
                table: "Utakmice");

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

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Utakmice_UtakmicaID",
                table: "Utakmice",
                column: "UtakmicaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Utakmice",
                table: "Utakmice",
                columns: new[] { "UtakmicaID", "DomaciTimID", "GostujuciTimID" });

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
    }
}
