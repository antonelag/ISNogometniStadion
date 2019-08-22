﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISNogometniStadion.Model.Requests
{
    public class TribineInsertRequest
    {
        [DataType(DataType.Text)]
        public string Naziv { get; set; }
        [RegularExpression(@"^[0-9]+$")]
        public int StadionID { get; set; }
       
        public int Cijena { get; set; }

    }
}
