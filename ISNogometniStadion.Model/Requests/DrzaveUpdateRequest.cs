using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISNogometniStadion.Model.Requests
{
    public class DrzaveUpdateRequest
    {
        [DataType(DataType.Text)]
        public string naziv { get; set; }
    }
}
