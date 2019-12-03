using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.Model
{
    public class UtakmiceeSearchRequest
    {
        public int? LigaID { get; set; }
        public int? StadionID { get; set; }
        public bool sveUtakmice { get; set; }
        public int? DrzavaID { get; set; }
        public int? GradID { get; set; }
        public DateTime? d1 { get; set; } = null;
        public DateTime? d2 { get; set; } = null;
        public decimal? cijena { get; set; }
        public int? TimID { get; set; }
        public bool PoStadionu { get; set; }
        public bool PoTimu { get; set; }
        public bool PoLokaciji { get; set; }



    }
}
