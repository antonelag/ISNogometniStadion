using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Services
{
    public interface IUtakmiceService
    {
        List<Utakmica> Get(UtakmiceeSearchRequest req);
        Utakmica GetById(int id);
        Utakmica Insert(UtakmiceInsertRequest req);
        Utakmica Update(int id, UtakmiceInsertRequest req);
        string Delete(int id);
    }
}
