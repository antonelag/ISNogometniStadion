
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISNogometniStadion.WebAPI.Database
{
    public class Ulaznice
    {
        [Key]
        public int UlaznicaID { get; set; }

        public int SjedaloID { get; set; }
        public Sjedala Sjedalo { get; set; }
        [ForeignKey("UtakmicaID")]
        public Utakmice Utakmica { get; set; }
        public string UlaznicaPodaci { get { return DatumKupnje.ToShortDateString() + ": " + Utakmica.DomaciTim.Naziv + "-" + Utakmica.GostujuciTim.Naziv + "; Korisnik: " + Korisnik.Ime + " " + Korisnik.Prezime; } }
        public int UtakmicaID { get; set; }
        [ForeignKey("KorisnikID")]
        public Korisnici Korisnik { get; set; }
        public int KorisnikID { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatumKupnje { get; set; }
        [DataType(DataType.Time)]
        public DateTime VrijemeKupnje { get; set; }
        public byte[] barcodeimg { get; set; }

        public Uplate Uplata { get; set; }
    }
}
