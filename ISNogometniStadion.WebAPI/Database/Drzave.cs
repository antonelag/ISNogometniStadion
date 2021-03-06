﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISNogometniStadion.WebAPI.Database
{
    public class Drzave
    {
        [Key]
        public int DrzavaID { get; set; }
        [RegularExpression(@"^[a-zA-Z ]+$")]
        public string Naziv { get; set; }
    }
}
