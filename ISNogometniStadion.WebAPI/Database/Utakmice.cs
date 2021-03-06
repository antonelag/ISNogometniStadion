﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISNogometniStadion.WebAPI.Database
{
    public class Utakmice
    {
        [Key]
        public int UtakmicaID { get; set; }

        [ForeignKey("DomaciTimID")]
        public Timovi DomaciTim { get; set; }
        public int DomaciTimID { get; set; }

        public string Utakmica { get { return DomaciTim.Naziv + "-" + GostujuciTim.Naziv + " - " + DatumOdigravanja.ToShortDateString(); } }

        [ForeignKey("GostujuciTimID")]
        public Timovi GostujuciTim { get; set; }
        public int GostujuciTimID { get; set; }

        [ForeignKey("LigaID")]
        public Lige Liga { get; set; }
        public int LigaID { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DatumOdigravanja { get; set; }
        [DataType(DataType.Time)]
        public DateTime VrijemeOdigravanja { get; set; }
        [ForeignKey("StadionID")]
        public Stadioni stadion { get; set; }
        public int StadionID { get; set; }
        public DateTime dateonly { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
    }
}
