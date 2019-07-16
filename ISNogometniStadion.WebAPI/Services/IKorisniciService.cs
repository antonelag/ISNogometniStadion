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
        List<Korisnik> Get();
        Korisnik Insert(KorisniciInsertRequest req);
    }
}
