using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISNogometniStadion.Model
{
    public class Ulaznica
    {
        public int UlaznicaID { get; set; }

        public int SjedaloID { get; set; }
        public string Oznaka { get; set; }
        public int UtakmicaID { get; set; }
        public string utakmica { get; set; }
        public string sektor { get; set; }
        public int KorisnikID { get; set; }
        public string korisnik { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatumKupnje { get; set; }
        [DataType(DataType.Time)]
        public DateTime VrijemeKupnje { get; set; }
        public byte[] barcodeimg { get; set; }
        public string color { get; set; }
        public decimal cijena { get; set; }
        public string cijenaPodaci { get { return cijena + " €"; } }

    }
}
