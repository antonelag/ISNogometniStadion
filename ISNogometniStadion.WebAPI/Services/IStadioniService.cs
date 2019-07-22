using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Services
{
    public interface IStadioniService
    {
        List<Stadion> Get(StadioniSearchRequest req);
        Stadion GetById(int id);
        Stadion Insert(StadioniInsertRequest req);
        Stadion Update(int id, StadioniInsertRequest req);
        string Delete(int id);
    }
}
