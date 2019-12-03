using System;
using System.Collections.Generic;
using System.Text;

namespace ISNogometniStadion.Model
{
    public class Zahtjev
    {
        public string naziv { get; set; }
        public int id { get; set; }
        public bool PretragaPotrebna { get; set; }
        public DateTime? d1 { get; set; } = null;
        public DateTime? d2 { get; set; } = null;
        public decimal? cijena { get; set; }

    }
}
