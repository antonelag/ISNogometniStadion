using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISNogometniStadion.Model.Requests
{
    public class KorisniciInsertRequest
    {
    [Required]
    public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        public DateTime DatumRodjenja { get; set; }
        [Required]
        public string telefon { get; set; }
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [MinLength(4)]
        public string korisnickoIme { get; set; }
        public string lozinka { get; set; }
        public string potvrdaLozinke { get; set; }
       
}
}
