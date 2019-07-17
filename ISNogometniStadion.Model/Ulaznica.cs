using System;
using System.Collections.Generic;
using System.Text;

namespace ISNogometniStadion.Model
{
    public class Ulaznica
    {
        public int UlaznicaID { get; set; }

        public int SjedaloID { get; set; }
        public string Sjedalo { get; set; }
        public int UtakmicaID { get; set; }
        public string Utakmica { get; set; }

        public int KorisnikID { get; set; }
        public string Korisnik { get; set; }
        public DateTime DatumKupnje { get; set; }
        public DateTime VrijemeKupnje { get; set; }
    }
}
