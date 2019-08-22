using System;
using System.Collections.Generic;
using System.Text;

namespace ISNogometniStadion.Model
{
    public class Sjedalo
    {
        public int SjedaloID { get; set; }
        public string Oznaka { get; set; }

        public string Sektor { get; set; }
        public int SektorID { get; set; }

        public bool Status { get; set; }
    }
}
