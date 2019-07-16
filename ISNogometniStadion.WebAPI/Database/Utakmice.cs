﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISNogometniStadion.WebAPI.Database
{
    public class Utakmice
    {
        public int UtakmicaID { get; set; }

        [ForeignKey("DomaciTimID")]
        public Timovi DomaciTim { get; set; }
        public int DomaciTimID { get; set; }

        [ForeignKey("GostujuciTimID")]
        public Timovi GostujuciTim { get; set; }
        public int GostujuciTimID { get; set; }

        public DateTime DatumOdigravanja { get; set; }
        public DateTime VrijemeOdigravanja { get; set; }
        [ForeignKey("StadionID")]
        public Stadion stadion { get; set; }
        public int StadionID { get; set; }
    }
}
