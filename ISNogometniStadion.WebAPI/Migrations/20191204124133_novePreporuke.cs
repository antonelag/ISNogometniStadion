using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ISNogometniStadion.WebAPI.Migrations
{
    public partial class novePreporuke : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PreporukePoLokaciji",
                columns: table => new
                {
                    PreporukaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnikID = table.Column<int>(nullable: false),
                    GradID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreporukePoLokaciji", x => x.PreporukaID);
                    table.ForeignKey(
                        name: "FK_PreporukePoLokaciji_Gradovi_GradID",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreporukePoLokaciji_Korisnici_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PreporukePoStadionu",
                columns: table => new
                {
                    PreporukaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnikID = table.Column<int>(nullable: false),
                    StadionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreporukePoStadionu", x => x.PreporukaID);
                    table.ForeignKey(
                        name: "FK_PreporukePoStadionu_Korisnici_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreporukePoStadionu_Stadioni_StadionID",
                        column: x => x.StadionID,
                        principalTable: "Stadioni",
                        principalColumn: "StadionID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PreporukePoTimu",
                columns: table => new
                {
                    PreporukaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnikID = table.Column<int>(nullable: false),
                    TimID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreporukePoTimu", x => x.PreporukaID);
                    table.ForeignKey(
                        name: "FK_PreporukePoTimu_Korisnici_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreporukePoTimu_Timovi_TimID",
                        column: x => x.TimID,
                        principalTable: "Timovi",
                        principalColumn: "TimID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PreporukePoLokaciji_GradID",
                table: "PreporukePoLokaciji",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_PreporukePoLokaciji_KorisnikID",
                table: "PreporukePoLokaciji",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_PreporukePoStadionu_KorisnikID",
                table: "PreporukePoStadionu",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_PreporukePoStadionu_StadionID",
                table: "PreporukePoStadionu",
                column: "StadionID");

            migrationBuilder.CreateIndex(
                name: "IX_PreporukePoTimu_KorisnikID",
                table: "PreporukePoTimu",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_PreporukePoTimu_TimID",
                table: "PreporukePoTimu",
                column: "TimID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PreporukePoLokaciji");

            migrationBuilder.DropTable(
                name: "PreporukePoStadionu");

            migrationBuilder.DropTable(
                name: "PreporukePoTimu");
        }
    }
}
