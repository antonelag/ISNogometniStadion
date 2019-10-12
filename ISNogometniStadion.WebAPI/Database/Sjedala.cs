using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISNogometniStadion.WebAPI.Database
{
    public class Sjedala
    {
        [Key]
        public int SjedaloID { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9 ]+$")]
        public string Oznaka { get; set; }

        [ForeignKey("SektorID")]
        public Sektori Sektor { get; set; }
        public int SektorID { get; set; }
        public bool Status { get; set; }

        public Ulaznice ulaznica { get; set; }
    }
}
