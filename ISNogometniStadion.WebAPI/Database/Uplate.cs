using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Database
{
    public class Uplate
    {
        [Key]
        public int UplataID { get; set; }
        public int UlaznicaID { get; set; }
        public Ulaznice Ulaznica { get; set; }
        public decimal Iznos { get; set; }
    }
}
