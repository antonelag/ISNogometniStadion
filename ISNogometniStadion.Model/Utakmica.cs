using System;
using System.Collections.Generic;
using System.Text;

namespace ISNogometniStadion.Model
{
    public class Utakmica
    {
        public int UtakmicaID { get; set; }

        public string DomaciTimm { get; set; }
        public int DomaciTimID { get; set; }

        public string GostujuciTim { get; set; }
        public int GostujuciTimID { get; set; }

        public DateTime DatumOdigravanja { get; set; }
        public DateTime VrijemeOdigravanja { get; set; }
        public string stadion { get; set; }
        public int StadionID { get; set; }
    }
}
