using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ISNogometniStadion.Model;

namespace ISNS.MA.Decision
{
    public class DecisionQuery : Decision
    {
        public string Title { get; set; }
        public Func<Zahtjev, Task<List<Utakmica>>> Test { get; set; }
        public Decision Positive { get; set; }
        public Decision Negative { get; set; }
        public List<Utakmica> listaUtakmica { get; set; }
        public async override Task<bool> Evaluate(Zahtjev z)
        {
            var l = await Test(z);
            listaUtakmica = new List<Utakmica>(l);
            if (l.Count > 0)
                return await Positive.Evaluate(z);
            else
                return await Negative.Evaluate(z);
        }
    }
}
