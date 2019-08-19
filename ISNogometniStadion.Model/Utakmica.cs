using System;
using System.Collections.Generic;
using System.Text;

namespace ISNogometniStadion.Model
{
    public class Utakmica
    {
        public int UtakmicaID { get; set; }

        public string DomaciTim { get; set; }
        public int DomaciTimID { get; set; }
        public string GostujuciTim { get; set; }
        public int GostujuciTimID { get; set; }
        public string UtakmicaPodaci { get { return DomaciTim + "-" + GostujuciTim + ", " + DatumOdigravanja.ToShortDateString(); }  }
        public DateTime DatumOdigravanja { get; set; }
        public DateTime VrijemeOdigravanja { get; set; }
        public string stadion { get; set; }
        public int StadionID { get; set; }
        public int LigaID { get; set; }
        public string Liga { get; set; }
    }
}
