using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Database
{
    public class PreporukePoLokaciji
    {
        [Key]
        public int PreporukaID { get; set; }
        [ForeignKey("KorisnikID")]
        public Korisnici Korisnik { get; set; }
        public int KorisnikID { get; set; }
        [ForeignKey("GradID")]
        public Gradovi Grad { get; set; }
        public int GradID { get; set; }
    }
}
