using Microsoft.EntityFrameworkCore.Migrations;

namespace ISNogometniStadion.WebAPI.Migrations
{
    public partial class izmjenaSjedalaSektori : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sjedala_Tribine_TribinaID",
                table: "Sjedala");

            migrationBuilder.RenameColumn(
                name: "TribinaID",
                table: "Sjedala",
                newName: "SektorID");

            migrationBuilder.RenameIndex(
                name: "IX_Sjedala_TribinaID",
                table: "Sjedala",
                newName: "IX_Sjedala_SektorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sjedala_Sektori_SektorID",
                table: "Sjedala",
                column: "SektorID",
                principalTable: "Sektori",
                principalColumn: "SektorID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sjedala_Sektori_SektorID",
                table: "Sjedala");

            migrationBuilder.RenameColumn(
                name: "SektorID",
                table: "Sjedala",
                newName: "TribinaID");

            migrationBuilder.RenameIndex(
                name: "IX_Sjedala_SektorID",
                table: "Sjedala",
                newName: "IX_Sjedala_TribinaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sjedala_Tribine_TribinaID",
                table: "Sjedala",
                column: "TribinaID",
                principalTable: "Tribine",
                principalColumn: "TribinaID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
