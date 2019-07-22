using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Services
{
    public interface IDrzaveService
    {
        List<Drzava> Get(DrzaveSearchRequest req);
        Drzava GetById(int id);
        Drzava Insert(DrzaveInsertRequest req);
        Drzava Update(int id, DrzaveInsertRequest req);
        string Delete(int id);
    }
}
