using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISNogometniStadion.WebAPI.Database
{
    public class Stadion
    {
        [Key]
        public int StadionID { get; set; }
        public string Naziv { get; set; }

        [ForeignKey("GradID")]
        public Gradovi Grad { get; set; }
        public int GradID { get; set; }
    }
}
