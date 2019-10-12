using System;
using System.Collections.Generic;
using System.Text;

namespace ISNogometniStadion.Model
{
    public class Tribina
    {

      
        public int TribinaID { get; set; }
        public string Naziv { get; set; }
        public int StadionID { get; set; }
        public string Stadion { get; set; }
        public decimal Cijena { get; set; }

    }
}
