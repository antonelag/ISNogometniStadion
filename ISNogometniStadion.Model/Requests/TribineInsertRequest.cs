using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISNogometniStadion.Model.Requests
{
    public class TribineInsertRequest
    {
        public string Naziv { get; set; }
        public int StadionID { get; set; }
       
        public decimal Cijena { get; set; }

    }
}
