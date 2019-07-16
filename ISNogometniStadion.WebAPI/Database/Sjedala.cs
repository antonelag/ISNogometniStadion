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
        public string Oznaka { get; set; }

        [ForeignKey("TribinaID")]
        public Tribine Tribina { get; set; }
        public int TribinaID { get; set; }


        public Ulaznice ulaznica { get; set; }
    }
}
