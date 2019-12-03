using ISNogometniStadion.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ISNS.MA.Decision
{
    public class DecisionResult:Decision
    {
        public bool result { get; set; }
        public List<Utakmica> utakmice { get; set; }
        public async override Task<bool> Evaluate(Zahtjev z)
        {
            return result;
        }
    }
}
