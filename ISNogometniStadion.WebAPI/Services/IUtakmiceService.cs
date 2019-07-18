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
        List<Utakmica> Get();
        Utakmica GetById(int id);
        Utakmica Insert(UtakmiceInsertRequest req);
        Utakmica Update(int id, UtakmiceUpdateRequest req);
        string Delete(int id);
    }
}
