using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISNogometniStadion.Model.Requests
{
    public class UlazniceInsertRequest
    {
        [RegularExpression(@"^[0-9]+$")]
        public int SjedaloID { get; set; }
        [RegularExpression(@"^[0-9]+$")]
        public int UtakmicaID { get; set; }
        [RegularExpression(@"^[0-9]+$")]
        public int KorisnikID { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatumKupnje { get; set; }
        [DataType(DataType.Time)]
        public DateTime VrijemeKupnje { get; set; }
    }
}
