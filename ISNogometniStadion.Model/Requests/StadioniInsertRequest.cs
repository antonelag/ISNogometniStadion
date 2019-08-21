using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISNogometniStadion.Model.Requests
{
    public class StadioniInsertRequest
    {
        [DataType(DataType.Text)]
        public string Naziv { get; set; }
        [DataType(DataType.Text)]
        public string Opis
        {
            get; set;
        }
            [RegularExpression(@"^[0-9]+$")]
        public int GradID { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
    }

}
