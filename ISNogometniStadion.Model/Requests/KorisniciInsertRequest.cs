using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISNogometniStadion.Model.Requests
{
    public class KorisniciInsertRequest
    {
        public string Ime { get; set; }

        public string Prezime { get; set; }

        public DateTime DatumRodjenja { get; set; }

        public int GradID { get; set; }

        public string telefon { get; set; }

        public string email { get; set; }

        public string korisnickoIme { get; set; }

        public string lozinka { get; set; }

        public string potvrdaLozinke { get; set; }
       
}
}
