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
        List<Sjedalo> Get();
        Sjedalo GetById(int id);
        Sjedalo Insert(SjedalaInsertRequest req);
        Sjedalo Update(int id, SjedaloUpdateRequest req);
        string Delete(int id);
    }
}
