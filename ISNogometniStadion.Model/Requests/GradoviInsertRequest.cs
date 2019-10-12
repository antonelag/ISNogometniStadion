using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISNogometniStadion.Model.Requests
{

    public class GradoviInsertRequest
    {
        public string Naziv { get; set; }
        public int DrzavaID { get; set; }
    }
}
