using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISNogometniStadion.Model.Requests
{
    public class DrzaveInsertRequest
    {
        [Required(ErrorMessage ="Ovo polje je obavezno")]
        [DataType(DataType.Text)]
        public string Naziv { get; set; }
    }
}
