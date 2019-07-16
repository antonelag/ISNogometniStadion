using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISNogometniStadion.WebAPI.Database
{
    public class Gradovi
    {
        [Key]
        public int GradID { get; set; }
        public string Naziv { get; set; }


        [ForeignKey("DrzavaID")]
        public Drzave Drzava { get; set; }
        public int DrzavaID { get; set; }
    }
}
