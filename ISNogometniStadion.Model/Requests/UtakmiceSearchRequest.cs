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
    }
}
