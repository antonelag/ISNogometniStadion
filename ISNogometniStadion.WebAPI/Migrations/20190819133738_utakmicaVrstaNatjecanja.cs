using Microsoft.EntityFrameworkCore.Migrations;

namespace ISNogometniStadion.WebAPI.Migrations
{
    public partial class utakmicaVrstaNatjecanja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LigaID",
                table: "Utakmice",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Utakmice_LigaID",
                table: "Utakmice",
                column: "LigaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Utakmice_Lige_LigaID",
                table: "Utakmice",
                column: "LigaID",
                principalTable: "Lige",
                principalColumn: "LigaID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Utakmice_Lige_LigaID",
                table: "Utakmice");

            migrationBuilder.DropIndex(
                name: "IX_Utakmice_LigaID",
                table: "Utakmice");

            migrationBuilder.DropColumn(
                name: "LigaID",
                table: "Utakmice");
        }
    }
}
