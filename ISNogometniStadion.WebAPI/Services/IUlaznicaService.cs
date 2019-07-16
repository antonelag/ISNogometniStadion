using ISNogometniStadion.Model;
using ISNogometniStadion.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Services
{
    public interface IUlaznicaService
    {
        IList<Ulaznice> Get();
        Ulaznice GetById(int id);
    }
}
