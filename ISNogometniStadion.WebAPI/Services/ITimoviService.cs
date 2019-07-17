using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Services
{
    public interface ITimoviService
    {
        List<Tim> Get();
        Tim GetById(int id);
        Tim Insert(TimoviInsertRequest req);
        Tim Update(int id, TimoviUpdateRequest req);
        string Delete(int id);
    }
}
