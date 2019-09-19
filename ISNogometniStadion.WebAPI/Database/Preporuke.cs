using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISNogometniStadion.WebAPI.Database
{
    public class Preporuke
    {
        [Key]
        public int PreporukaID { get; set; }
        public int KorisnikID { get; set; }
        public int TimID { get; set; }
        public int BrojKupljenihUlaznica { get; set; }

    }
}
