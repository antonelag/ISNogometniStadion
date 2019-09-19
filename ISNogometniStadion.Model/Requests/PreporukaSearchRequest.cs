using System;
using System.Collections.Generic;
using System.Text;

namespace ISNogometniStadion.Model.Requests
{
    public class PreporukaSearchRequest
    {
        public int? KorisnikID { get; set; }
        public int? PrviTimID { get; set; }
        public int? DrugiTimID { get; set; }
    }
}
