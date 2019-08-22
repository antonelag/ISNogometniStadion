using System;
using System.Collections.Generic;
using System.Text;

namespace ISNogometniStadion.Model.Requests
{
    public class SjedalaInsertRequest
    {

        public string Oznaka { get; set; }

        public int SektorID { get; set; }
        public bool Status { get; set; }
    }
}
