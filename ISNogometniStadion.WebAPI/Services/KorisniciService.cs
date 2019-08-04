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
    public class KorisniciService : BaseCRUDService<Model.Korisnik, Model.KorisniciSearchRequest, Database.Korisnici,KorisniciInsertRequest, KorisniciInsertRequest>
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;

        public KorisniciService(IMapper mapper, ISNogometniStadionContext context) : base(mapper, context)
        {
            _context = context;
            _mapper = mapper;

        }
        public override List<Korisnik> Get(KorisniciSearchRequest search)
        {
            var q = _context.Set<Database.Korisnici>().AsQueryable();

            if (!string.IsNullOrEmpty(search?.ImePrezime))
            {
                q = q.Where(s => (s.Ime.StartsWith(search.ImePrezime)) || s.Prezime.StartsWith(search.ImePrezime));
            }
            var list = q.ToList();
            return _mapper.Map<List<Korisnik>>(list);
            
        }
    }
}
