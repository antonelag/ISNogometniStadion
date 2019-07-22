using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISNogometniStadion.Model
{
    public class Korisnik
    {
        [Key]
        public int KorisnikID { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string telefon { get; set; }
        public DateTime datumRodjenja { get; set; }
        public string email { get; set; }
        public string korisnickoIme { get; set; }
        public int gradID { get; set; }
        public string Naziv { get; set; }
        public string lozinka { get; set; }
        public string potvrdaLozinke { get; set; }

    }
}
