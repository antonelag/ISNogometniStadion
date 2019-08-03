using System;
using System.Collections.Generic;
using System.Text;

namespace ISNogometniStadion.Model
{
    public class Tim
    {
        public int TimID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Stadion { get; set; }
        public int StadionID { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }

    }
}
