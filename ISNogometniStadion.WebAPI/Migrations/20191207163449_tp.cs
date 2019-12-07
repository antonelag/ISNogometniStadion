using Microsoft.EntityFrameworkCore.Migrations;

namespace ISNogometniStadion.WebAPI.Migrations
{
    public partial class tp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Preporuke_TimID",
                table: "Preporuke",
                column: "TimID");

            migrationBuilder.AddForeignKey(
                name: "FK_Preporuke_Timovi_TimID",
                table: "Preporuke",
                column: "TimID",
                principalTable: "Timovi",
                principalColumn: "TimID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Preporuke_Timovi_TimID",
                table: "Preporuke");

            migrationBuilder.DropIndex(
                name: "IX_Preporuke_TimID",
                table: "Preporuke");
        }
    }
}
