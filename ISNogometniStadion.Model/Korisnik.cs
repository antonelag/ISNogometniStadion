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
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public string korisnickoIme { get; set; }
        public int GradID { get; set; }
        public string Grad { get; set; }

    }
}
