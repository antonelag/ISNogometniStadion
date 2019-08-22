using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.Model
{
    public class SektoriSearchRequest
    {
        public string Naziv { get; set; }
        public int? TribinaID { get; set; }
        public int StadionID { get; set; }
        public int[] nizTribina { get; set; }
    }
}
