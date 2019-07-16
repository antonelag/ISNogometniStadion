using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISNogometniStadion.WebAPI.Database
{
    public class Tribine
    {
        [Key]
        public int TribinaID { get; set; }
        public string Naziv { get; set; }

        [ForeignKey("StadionID)")]
        public Stadion Stadion { get; set; }
        public int StadionID { get; set; }
    }
}
