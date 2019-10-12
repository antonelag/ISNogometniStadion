using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISNogometniStadion.Model.Requests
{
    public class TimoviInsertRequest
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int StadionID { get; set; }
        public int LigaID { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
    }
}
