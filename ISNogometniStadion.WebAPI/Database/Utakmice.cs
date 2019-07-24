using System;
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

        public DateTime DatumOdigravanja { get; set; }
        public DateTime VrijemeOdigravanja { get; set; }
        [ForeignKey("StadionID")]
        public Stadioni stadion { get; set; }
        public int StadionID { get; set; }
    }
}
