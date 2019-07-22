using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Services
{
    public interface IKorisniciService
    {
        List<Korisnik> Get(KorisniciSearchRequest req);
        Korisnik GetById(int id);
        Korisnik Insert(KorisniciInsertRequest req);
        Korisnik Update(int id, KorisniciInsertRequest req);
        string Delete(int id);
    }
}
