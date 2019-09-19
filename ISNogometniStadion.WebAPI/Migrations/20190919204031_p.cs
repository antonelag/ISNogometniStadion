using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ISNogometniStadion.WebAPI.Migrations
{
    public partial class p : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Preporuke");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Preporuke",
                columns: table => new
                {
                    PreporukaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrojKupljenihUlaznica = table.Column<int>(nullable: false),
                    KorisnikID = table.Column<int>(nullable: false),
                    TimID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preporuke", x => x.PreporukaID);
                    table.ForeignKey(
                        name: "FK_Preporuke_Korisnici_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Preporuke_KorisnikID",
                table: "Preporuke",
                column: "KorisnikID");
        }
    }
}
