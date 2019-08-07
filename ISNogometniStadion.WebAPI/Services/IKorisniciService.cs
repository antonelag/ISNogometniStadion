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
        List<Model.Korisnik> Get(KorisniciSearchRequest request);

        Model.Korisnik GetById(int id);

        Model.Korisnik Insert(KorisniciInsertRequest request);

        Model.Korisnik Update(int id, KorisniciInsertRequest request);
        Model.Korisnik Authenticiraj(string username, string pass);

    }
}
