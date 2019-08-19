using System;
using System.Collections.Generic;
using System.Text;

namespace ISNogometniStadion.Model.Requests
{
    public class UtakmiceInsertRequest
    {
        public int DomaciTimID { get; set; }

        public int GostujuciTimID { get; set; }

        public DateTime DatumOdigravanja { get; set; }
        public DateTime VrijemeOdigravanja { get; set; }
        public int StadionID { get; set; }
        public int LigaID { get; set; }

    }
}
