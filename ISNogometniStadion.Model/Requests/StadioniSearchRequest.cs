using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.Model
{
    public class StadioniSearchRequest

    {
        public string Naziv { get; set; }
        public int? GradID { get; set; }
        public int? DrzavaID { get; set; }
    }
}
