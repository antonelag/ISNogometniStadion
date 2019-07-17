using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISNogometniStadion.Model.Requests
{
    public class TimoviInsertRequest
    {
        [Required(ErrorMessage ="Ovo polje je obavezno")]
        [DataType(DataType.Text)]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        [DataType(DataType.Text)]
        public string Opis { get; set; }
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        [RegularExpression(@"^[0-9]+$")]
        public int StadionID { get; set; }
    }
}
