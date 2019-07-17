﻿// <auto-generated />
using System;
using ISNogometniStadion.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ISNogometniStadion.WebAPI.Migrations
{
    [DbContext(typeof(ISNogometniStadionContext))]
    [Migration("20190717150419_promjenaUlaznica")]
    partial class promjenaUlaznica
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ISNogometniStadion.WebAPI.Database.Drzave", b =>
                {
                    b.Property<int>("DrzavaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("DrzavaID");

                    b.ToTable("Drzave");
                });

            modelBuilder.Entity("ISNogometniStadion.WebAPI.Database.Gradovi", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaID");

                    b.Property<string>("Naziv");

                    b.HasKey("GradID");

                    b.HasIndex("DrzavaID");

                    b.ToTable("Gradovi");
                });

            modelBuilder.Entity("ISNogometniStadion.WebAPI.Database.Korisnici", b =>
                {
                    b.Property<int>("KorisnikID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<int>("GradID");

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<string>("email");

                    b.Property<string>("korisnickoIme");

                    b.Property<string>("lozinka");

                    b.Property<string>("telefon");

                    b.HasKey("KorisnikID");

                    b.HasIndex("GradID");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("ISNogometniStadion.WebAPI.Database.Sjedala", b =>
                {
                    b.Property<int>("SjedaloID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Oznaka");

                    b.Property<int>("TribinaID");

                    b.HasKey("SjedaloID");

                    b.HasIndex("TribinaID");

                    b.ToTable("Sjedala");
                });

            modelBuilder.Entity("ISNogometniStadion.WebAPI.Database.Stadioni", b =>
                {
                    b.Property<int>("StadionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GradID");

                    b.Property<string>("Naziv");

                    b.HasKey("StadionID");

                    b.HasIndex("GradID");

                    b.ToTable("Stadioni");
                });

            modelBuilder.Entity("ISNogometniStadion.WebAPI.Database.Timovi", b =>
                {
                    b.Property<int>("TimID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.Property<int>("StadionID");

                    b.HasKey("TimID");

                    b.HasIndex("StadionID");

                    b.ToTable("Timovi");
                });

            modelBuilder.Entity("ISNogometniStadion.WebAPI.Database.Tribine", b =>
                {
                    b.Property<int>("TribinaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.Property<int>("StadionID");

                    b.HasKey("TribinaID");

                    b.HasIndex("StadionID");

                    b.ToTable("Tribine");
                });

            modelBuilder.Entity("ISNogometniStadion.WebAPI.Database.Ulaznice", b =>
                {
                    b.Property<int>("UlaznicaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumKupnje");

                    b.Property<int>("KorisnikID");

                    b.Property<int>("SjedaloID");

                    b.Property<int>("UtakmicaID");

                    b.Property<int?>("UtakmicaID1");

                    b.Property<DateTime>("VrijemeKupnje");

                    b.Property<int?>("utakmicaDomaciTimID");

                    b.Property<int?>("utakmicaGostujuciTimID");

                    b.HasKey("UlaznicaID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("SjedaloID")
                        .IsUnique();

                    b.HasIndex("UtakmicaID1", "utakmicaDomaciTimID", "utakmicaGostujuciTimID");

                    b.ToTable("Ulaznice");
                });

            modelBuilder.Entity("ISNogometniStadion.WebAPI.Database.Utakmice", b =>
                {
                    b.Property<int>("UtakmicaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DomaciTimID");

                    b.Property<int>("GostujuciTimID");

                    b.Property<DateTime>("DatumOdigravanja");

                    b.Property<int>("StadionID");

                    b.Property<DateTime>("VrijemeOdigravanja");

                    b.HasKey("UtakmicaID", "DomaciTimID", "GostujuciTimID");

                    b.HasAlternateKey("UtakmicaID");

                    b.HasIndex("DomaciTimID");

                    b.HasIndex("GostujuciTimID");

                    b.HasIndex("StadionID");

                    b.ToTable("Utakmice");
                });

            modelBuilder.Entity("ISNogometniStadion.WebAPI.Database.Gradovi", b =>
                {
                    b.HasOne("ISNogometniStadion.WebAPI.Database.Drzave", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ISNogometniStadion.WebAPI.Database.Korisnici", b =>
                {
                    b.HasOne("ISNogometniStadion.WebAPI.Database.Gradovi", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ISNogometniStadion.WebAPI.Database.Sjedala", b =>
                {
                    b.HasOne("ISNogometniStadion.WebAPI.Database.Tribine", "Tribina")
                        .WithMany()
                        .HasForeignKey("TribinaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ISNogometniStadion.WebAPI.Database.Stadioni", b =>
                {
                    b.HasOne("ISNogometniStadion.WebAPI.Database.Gradovi", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ISNogometniStadion.WebAPI.Database.Timovi", b =>
                {
                    b.HasOne("ISNogometniStadion.WebAPI.Database.Stadioni", "Stadion")
                        .WithMany()
                        .HasForeignKey("StadionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ISNogometniStadion.WebAPI.Database.Tribine", b =>
                {
                    b.HasOne("ISNogometniStadion.WebAPI.Database.Stadioni", "Stadion")
                        .WithMany()
                        .HasForeignKey("StadionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ISNogometniStadion.WebAPI.Database.Ulaznice", b =>
                {
                    b.HasOne("ISNogometniStadion.WebAPI.Database.Korisnici", "korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ISNogometniStadion.WebAPI.Database.Sjedala", "sjedalo")
                        .WithOne("ulaznica")
                        .HasForeignKey("ISNogometniStadion.WebAPI.Database.Ulaznice", "SjedaloID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ISNogometniStadion.WebAPI.Database.Utakmice", "utakmica")
                        .WithMany()
                        .HasForeignKey("UtakmicaID1", "utakmicaDomaciTimID", "utakmicaGostujuciTimID");
                });

            modelBuilder.Entity("ISNogometniStadion.WebAPI.Database.Utakmice", b =>
                {
                    b.HasOne("ISNogometniStadion.WebAPI.Database.Timovi", "DomaciTim")
                        .WithMany()
                        .HasForeignKey("DomaciTimID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ISNogometniStadion.WebAPI.Database.Timovi", "GostujuciTim")
                        .WithMany()
                        .HasForeignKey("GostujuciTimID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ISNogometniStadion.WebAPI.Database.Stadioni", "stadion")
                        .WithMany()
                        .HasForeignKey("StadionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
