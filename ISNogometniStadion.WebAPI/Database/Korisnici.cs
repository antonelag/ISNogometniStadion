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
        [RegularExpression(@"^[a-zA-Z ]+$")]
        public string Ime { get; set; }
        [RegularExpression(@"^[a-zA-Z -]+$")]
        public string Prezime { get; set; }

        public string Korisnik { get { return Ime + " " + Prezime; } }
        [DataType(DataType.Date)]
        public DateTime DatumRodjenja { get; set; }
        [RegularExpression(@"^[+]{1}\d{3}[ ]?\d{2}[ ]?\d{3}[ ]?\d{3}")]
        public string telefon { get; set; }
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")]
        public string email { get; set; }
        [RegularExpression(@"^(?=.{8,40}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$")]
        public string korisnickoIme { get; set; }

        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        [ForeignKey("GradID")]
        public Gradovi Grad { get; set; }
        public int GradID { get; set; }
    }
}
