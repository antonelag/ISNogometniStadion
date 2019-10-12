using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISNogometniStadion.Model
{
    public class Uplata
    {
        public int UplataID { get; set; }
        public int UlaznicaID { get; set; }
        public Ulaznica Ulaznica { get; set; }
        public decimal Iznos { get; set; }
        public string UplataPodaci { get; set; }
    }
}
