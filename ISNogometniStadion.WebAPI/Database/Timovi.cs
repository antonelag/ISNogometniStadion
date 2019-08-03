using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace ISNogometniStadion.WebAPI.Database
{
    public class Timovi
    {
        [Key]
        public int TimID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
      
        [ForeignKey("StadionID")]
        public Stadioni Stadion { get; set; }
        public int StadionID { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
    }
}
