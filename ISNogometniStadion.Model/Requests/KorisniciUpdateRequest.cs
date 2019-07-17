using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISNogometniStadion.Model.Requests
{
    public class KorisniciUpdateRequest
    {
       
        [DataType(DataType.Text)]
        public string Ime { get; set; }

        [DataType(DataType.Text)]
        public string Prezime { get; set; }

        [DataType(DataType.Date)]
        public DateTime DatumRodjenja { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string telefon { get; set; }

        [EmailAddress(ErrorMessage = "Pogresan format")]
        public string email { get; set; }

        [MinLength(4)]
        public string korisnickoIme { get; set; }

        [DataType(DataType.Password)]
        public string lozinka { get; set; }

        [DataType(DataType.Password)]
        public string potvrdaLozinke { get; set; }

        [RegularExpression(@"^[0-9]+$")]
        public int GradID { get; set; }
    }
}
