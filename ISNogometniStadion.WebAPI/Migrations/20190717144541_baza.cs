using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ISNogometniStadion.WebAPI.Migrations
{
    public partial class baza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzave",
                columns: table => new
                {
                    DrzavaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzave", x => x.DrzavaID);
                });

            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    GradID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    DrzavaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => x.GradID);
                    table.ForeignKey(
                        name: "FK_Gradovi_Drzave_DrzavaID",
                        column: x => x.DrzavaID,
                        principalTable: "Drzave",
                        principalColumn: "DrzavaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    telefon = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    korisnickoIme = table.Column<string>(nullable: true),
                    lozinka = table.Column<string>(nullable: true),
                    GradID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.KorisnikID);
                    table.ForeignKey(
                        name: "FK_Korisnici_Gradovi_GradID",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stadioni",
                columns: table => new
                {
                    StadionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    GradID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stadioni", x => x.StadionID);
                    table.ForeignKey(
                        name: "FK_Stadioni_Gradovi_GradID",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Timovi",
                columns: table => new
                {
                    TimID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    StadionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timovi", x => x.TimID);
                    table.ForeignKey(
                        name: "FK_Timovi_Stadioni_StadionID",
                        column: x => x.StadionID,
                        principalTable: "Stadioni",
                        principalColumn: "StadionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tribine",
                columns: table => new
                {
                    TribinaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    StadionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tribine", x => x.TribinaID);
                    table.ForeignKey(
                        name: "FK_Tribine_Stadioni_StadionID",
                        column: x => x.StadionID,
                        principalTable: "Stadioni",
                        principalColumn: "StadionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Utakmice",
                columns: table => new
                {
                    UtakmicaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DomaciTimID = table.Column<int>(nullable: false),
                    GostujuciTimID = table.Column<int>(nullable: false),
                    DatumOdigravanja = table.Column<DateTime>(nullable: false),
                    VrijemeOdigravanja = table.Column<DateTime>(nullable: false),
                    StadionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utakmice", x => new { x.UtakmicaID, x.DomaciTimID, x.GostujuciTimID });
                    table.UniqueConstraint("AK_Utakmice_UtakmicaID", x => x.UtakmicaID);
                    table.ForeignKey(
                        name: "FK_Utakmice_Timovi_DomaciTimID",
                        column: x => x.DomaciTimID,
                        principalTable: "Timovi",
                        principalColumn: "TimID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Utakmice_Timovi_GostujuciTimID",
                        column: x => x.GostujuciTimID,
                        principalTable: "Timovi",
                        principalColumn: "TimID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Utakmice_Stadioni_StadionID",
                        column: x => x.StadionID,
                        principalTable: "Stadioni",
                        principalColumn: "StadionID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Sjedala",
                columns: table => new
                {
                    SjedaloID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Oznaka = table.Column<string>(nullable: true),
                    TribinaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sjedala", x => x.SjedaloID);
                    table.ForeignKey(
                        name: "FK_Sjedala_Tribine_TribinaID",
                        column: x => x.TribinaID,
                        principalTable: "Tribine",
                        principalColumn: "TribinaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ulaznice",
                columns: table => new
                {
                    UlaznicaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SjedaloID = table.Column<int>(nullable: false),
                    UtakmicaID = table.Column<int>(nullable: false),
                    KorisnikID = table.Column<int>(nullable: false),
                    DatumKupnje = table.Column<DateTime>(nullable: false),
                    VrijemeKupnje = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulaznice", x => new { x.UlaznicaID, x.UtakmicaID, x.SjedaloID });
                    table.ForeignKey(
                        name: "FK_Ulaznice_Korisnici_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ulaznice_Sjedala_SjedaloID",
                        column: x => x.SjedaloID,
                        principalTable: "Sjedala",
                        principalColumn: "SjedaloID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Ulaznice_Utakmice_UtakmicaID",
                        column: x => x.UtakmicaID,
                        principalTable: "Utakmice",
                        principalColumn: "UtakmicaID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gradovi_DrzavaID",
                table: "Gradovi",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_GradID",
                table: "Korisnici",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Sjedala_TribinaID",
                table: "Sjedala",
                column: "TribinaID");

            migrationBuilder.CreateIndex(
                name: "IX_Stadioni_GradID",
                table: "Stadioni",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Timovi_StadionID",
                table: "Timovi",
                column: "StadionID");

            migrationBuilder.CreateIndex(
                name: "IX_Tribine_StadionID",
                table: "Tribine",
                column: "StadionID");

            migrationBuilder.CreateIndex(
                name: "IX_Ulaznice_KorisnikID",
                table: "Ulaznice",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Ulaznice_SjedaloID",
                table: "Ulaznice",
                column: "SjedaloID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ulaznice_UtakmicaID",
                table: "Ulaznice",
                column: "UtakmicaID");

            migrationBuilder.CreateIndex(
                name: "IX_Utakmice_DomaciTimID",
                table: "Utakmice",
                column: "DomaciTimID");

            migrationBuilder.CreateIndex(
                name: "IX_Utakmice_GostujuciTimID",
                table: "Utakmice",
                column: "GostujuciTimID");

            migrationBuilder.CreateIndex(
                name: "IX_Utakmice_StadionID",
                table: "Utakmice",
                column: "StadionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ulaznice");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Sjedala");

            migrationBuilder.DropTable(
                name: "Utakmice");

            migrationBuilder.DropTable(
                name: "Tribine");

            migrationBuilder.DropTable(
                name: "Timovi");

            migrationBuilder.DropTable(
                name: "Stadioni");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "Drzave");
        }
    }
}
