using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISNogometniStadion.Model;
using ISNogometniStadion.WebAPI.Database;

namespace ISNogometniStadion.WebAPI.Services
{
    public class UlaznicaService : IUlaznicaService
    {
      

        public Ulaznice GetById(int id)
        {
            var item = new Ulaznice()
            {
                UlaznicaID = 2,
                KorisnikID = 2,
                SjedaloID = 2,
            };

            return item;
        }

        IList<Ulaznice> IUlaznicaService.Get()
        {
            var list = new List<Ulaznice>()
            {
                new Ulaznice()
                {
                    UlaznicaID=1,
                    KorisnikID=1,
                    SjedaloID=1,
                    UtakmicaID=1
                },
                new Ulaznice()
                {
                    UlaznicaID=2,
                    KorisnikID=2,
                    SjedaloID=2,
                    UtakmicaID=2
                }
            };
            return list;
        }
    }
}
