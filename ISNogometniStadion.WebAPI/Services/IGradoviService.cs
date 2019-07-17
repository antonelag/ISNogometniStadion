using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Services
{
    public interface IGradoviService
    {
        List<Grad> Get();
        Grad GetById(int id);
        Grad Insert(GradoviInsertRequest req);
        Grad Update(int id,GradoviUpdateRequest req);
        string Delete(int id);
    }
}
