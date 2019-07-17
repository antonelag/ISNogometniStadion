﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISNogometniStadion.Model.Requests
{
    public class KorisniciInsertRequest
    {
        [Required(ErrorMessage ="Ovo polje je obavezno!")]
        [DataType(DataType.Text)]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno!")]
        [DataType(DataType.Text)]
        public string Prezime { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno!")]
        [DataType(DataType.Date)]
        public DateTime DatumRodjenja { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno!")]
        [DataType(DataType.PhoneNumber)]
        public string telefon { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno!")]
        [EmailAddress(ErrorMessage ="Pogresan format")]
        public string email { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno!")]
        [MinLength(4)]
        public string korisnickoIme { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno!")]
        [DataType(DataType.Password)]
        public string lozinka { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno!")]
        [DataType(DataType.Password)]
        public string potvrdaLozinke { get; set; }
       
}
}
