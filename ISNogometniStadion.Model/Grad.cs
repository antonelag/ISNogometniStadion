using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISNogometniStadion.Model
{
    public class Grad
    {
        [Key]
        public int GradID { get; set; }
        public string Naziv { get; set; }
        public string Drzava { get; set; }
        public int DrzavaID { get; set; }
    }
}
