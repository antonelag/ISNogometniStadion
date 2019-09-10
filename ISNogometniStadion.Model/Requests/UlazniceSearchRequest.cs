using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.Model
{
    public class UlazniceSearchRequest
    {
        public int? KorisnikID { get; set; }
        public int? Godina { get; set; }
        public int? UtakmicaID { get; set; }
    }
}
