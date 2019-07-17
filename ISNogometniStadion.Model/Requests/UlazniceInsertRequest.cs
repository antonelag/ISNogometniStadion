using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISNogometniStadion.Model.Requests
{
    public class UlazniceInsertRequest
    {
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        [RegularExpression(@"^[0-9]+$")]
        public int SjedaloID { get; set; }
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        [RegularExpression(@"^[0-9]+$")]
        public int UtakmicaID { get; set; }
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        [RegularExpression(@"^[0-9]+$")]
        public int KorisnikID { get; set; }
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        [DataType(DataType.Date)]
        public DateTime DatumKupnje { get; set; }
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        [DataType(DataType.Time)]
        public DateTime VrijemeKupnje { get; set; }
    }
}
