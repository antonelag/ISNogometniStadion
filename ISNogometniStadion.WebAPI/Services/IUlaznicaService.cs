using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Services
{
    public interface IUlaznicaService
    {
        List<Ulaznica> Get(UlazniceSearchRequest req);
        Ulaznica GetById(int id);
        Ulaznica Insert(UlazniceInsertRequest req);
        Ulaznica Update(int id, UlazniceInsertRequest req);
        string Delete(int id);
    }
}
