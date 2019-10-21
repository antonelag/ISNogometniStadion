using ISNogometniStadion.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Database
{
    public class ISNogometniStadionContext : DbContext
    {

        public ISNogometniStadionContext()
        {
        }
        public ISNogometniStadionContext(DbContextOptions<ISNogometniStadionContext> options) : base(options)
        {

        }

        public DbSet<Drzave> Drzave { get; set; }
        public DbSet<Gradovi> Gradovi { get; set; }
        public DbSet<Korisnici> Korisnici { get; set; }
        public DbSet<Sjedala> Sjedala { get; set; }
        public DbSet<Stadioni> Stadioni { get; set; }
        public DbSet<Timovi> Timovi { get; set; }
        public DbSet<Tribine> Tribine { get; set; }
        public DbSet<Ulaznice> Ulaznice { get; set; }
        public DbSet<Utakmice> Utakmice { get; set; }
        public DbSet<Sektori> Sektori { get; set; }
        public DbSet<Lige> Lige { get; set; }
        public DbSet<Preporuke> Preporuke { get; set; }
        public DbSet<Uplate> Uplate { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=.;initial catalog=IB160125; integrated security = True; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sjedala>()
                .HasOne(s => s.ulaznica)
                .WithOne(ad => ad.Sjedalo)
                .HasForeignKey<Ulaznice>(ad => ad.SjedaloID);
            modelBuilder.Entity<Ulaznice>()
                .HasOne(s => s.Uplata)
                .WithOne(ad => ad.Ulaznica)
               .HasForeignKey<Uplate>(ad => ad.UlaznicaID);

        }



    }
}
