using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISNogometniStadion.WebAPI.Database
{
    public class Lige
    {
        [Key]
        public int LigaID { get; set; }
        public string Naziv { get; set; }
        [ForeignKey("DrzavaID")]
        public Drzave Drzava { get; set; }
        public int DrzavaID { get; set; }

    }
}
