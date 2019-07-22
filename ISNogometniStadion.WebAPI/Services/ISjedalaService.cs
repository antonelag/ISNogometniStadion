using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Services
{
    public interface ISjedalaService
    {
        List<Sjedalo> Get(SjedalaSearchRequest req);
        Sjedalo GetById(int id);
        Sjedalo Insert(SjedalaInsertRequest req);
        Sjedalo Update(int id, SjedalaInsertRequest req);
        string Delete(int id);
    }
}
