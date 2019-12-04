using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Database
{
    public class PreporukePoTimu
    {
        [Key]
        public int PreporukaID { get; set; }
        [ForeignKey("KorisnikID")]
        public Korisnici Korisnik { get; set; }
        public int KorisnikID { get; set; }
        [ForeignKey("TimID")]
        public Timovi Tim { get; set; }
        public int TimID { get; set; }
    }
}
