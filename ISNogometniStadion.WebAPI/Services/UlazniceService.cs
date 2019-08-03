using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WebAPI.Database;

namespace ISNogometniStadion.WebAPI.Services
{
    public class UlazniceService : BaseCRUDService<Model.Ulaznica, Model.UlazniceSearchRequest, Database.Ulaznice,UlazniceInsertRequest,UlazniceInsertRequest>
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;

        public UlazniceService(IMapper mapper, ISNogometniStadionContext context) : base(mapper, context)
        {
            _context = context;
            _mapper = mapper;

        }
        public override List<Ulaznica> Get(UlazniceSearchRequest search)
        {
            var q = _context.Set<Database.Ulaznice>().AsQueryable();

            if (search?.KorisnikID.HasValue==true)
            {
                q = q.Where(s => s.Korisnik.KorisnikID == search.KorisnikID);
            }
            var list = q.ToList();
            return _mapper.Map<List<Ulaznica>>(list);
            
        }
    }
}
