using System;
using System.Collections.Generic;
using System.Text;

namespace ISNogometniStadion.Model
{
    public class Stadion
    {
        public int StadionID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int GradID { get; set; }
        public string Grad { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
    }
}
