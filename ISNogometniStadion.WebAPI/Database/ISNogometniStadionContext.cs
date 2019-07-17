using ISNogometniStadion.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Database
{
    public class ISNogometniStadionContext:DbContext
    {
        public ISNogometniStadionContext()
        {

        }
        public ISNogometniStadionContext(DbContextOptions<ISNogometniStadionContext> options):base(options)
        {

        }

        public virtual DbSet<Drzave> Drzave { get; set; }
        public virtual DbSet<Gradovi> Gradovi { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<Sjedala> Sjedala { get; set; }
        public virtual DbSet<Stadioni> Stadioni { get; set; }
        public virtual DbSet<Timovi> Timovi { get; set; }
        public virtual DbSet<Tribine> Tribine { get; set; }
        public virtual DbSet<Ulaznice> Ulaznice { get; set; }
        public virtual DbSet<Utakmice> Utakmice { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost; Database =ISNogometniStadionDB; Trusted_Connection = True; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sjedala>()
                .HasOne(s => s.ulaznica)
                .WithOne(ad => ad.sjedalo)
                .HasForeignKey<Ulaznice>(ad => ad.SjedaloID);

            //modelBuilder.Entity<Ulaznice>()
            //  .HasKey(c => new { c.UlaznicaID, c.UtakmicaID,c.SjedaloID });
           // modelBuilder.Entity<Ulaznice>().Property(p => p.UlaznicaID).ValueGeneratedOnAdd();
            //modelBuilder.Entity<Ulaznice>()
            //    .HasOne(s => s.utakmica)
            //    .WithMany()
            //    .HasPrincipalKey(y => y.UtakmicaID);

            //modelBuilder.Entity<Utakmice>()
            //    .HasKey(a => new { a.UtakmicaID, a.DomaciTimID, a.GostujuciTimID });
            
                
            //modelBuilder.Entity<Utakmice>().Property(p => p.UtakmicaID).ValueGeneratedOnAdd();
        }



    }
}
