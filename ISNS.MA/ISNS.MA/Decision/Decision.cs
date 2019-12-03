using ISNogometniStadion.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ISNS.MA.Decision
{
    public abstract class Decision
    {
        public abstract Task<bool> Evaluate(Zahtjev z);
    }
}
