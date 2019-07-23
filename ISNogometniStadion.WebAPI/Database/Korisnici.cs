using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISNogometniStadion.WebAPI.Database
{
    public class Korisnici
    {
        [Key]
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string Korisnik { get { return Ime + " " + Prezime; } }
        public DateTime DatumRodjenja { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public string korisnickoIme { get; set; }
        public string lozinka { get; set; }
        [ForeignKey("GradID")]
        public Gradovi Grad { get; set; }
        public int GradID { get; set; }
    }
}
