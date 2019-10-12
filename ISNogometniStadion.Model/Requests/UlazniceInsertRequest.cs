using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISNogometniStadion.Model.Requests
{
    public class UlazniceInsertRequest
    {
        public int SjedaloID { get; set; }
        public int UtakmicaID { get; set; }
        public int KorisnikID { get; set; }
        public DateTime DatumKupnje { get; set; }
        public DateTime VrijemeKupnje { get; set; }

        public byte[] barcodeimg { get; set; }
    }
}
