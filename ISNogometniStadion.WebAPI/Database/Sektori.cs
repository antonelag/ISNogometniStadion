using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISNogometniStadion.WebAPI.Database
{
    public class Sektori
    {
        [Key]
        public int SektorID { get; set; }
        public string Naziv { get; set; }

        [ForeignKey("TribinaID")]
        public Tribine Tribina { get; set; }
        public int TribinaID { get; set; }
    }
}
