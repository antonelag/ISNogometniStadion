using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISNogometniStadion.Model.Requests
{
    public class UplateInsertRequest
    {
        public int UlaznicaID { get; set; }
        public decimal Iznos { get; set; }

    }
}
