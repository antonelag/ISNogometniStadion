using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WebAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace ISNogometniStadion.WebAPI.Services
{
    public class UtakmiceService : BaseCRUDService<Model.Utakmica, Model.UtakmiceeSearchRequest, Database.Utakmice,UtakmiceInsertRequest, UtakmiceInsertRequest>
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;

        public UtakmiceService(IMapper mapper, ISNogometniStadionContext context) : base(mapper, context)
        {
            _context = context;
            _mapper = mapper;

        }
        public override List<Utakmica> Get(UtakmiceeSearchRequest search)
        {
            var q = _context.Set<Database.Utakmice>().AsQueryable();

            if (!string.IsNullOrEmpty(search?.NazivTima))
            {
                q = q.
                    Include(a=>a.DomaciTim)
                    .Include(a=>a.GostujuciTim)
                    .Where(s => ((s.DomaciTim.Naziv.StartsWith(search.NazivTima)) || s.GostujuciTim.Naziv.StartsWith(search.NazivTima) ));
            }
            var list = q.ToList();
            return _mapper.Map<List<Utakmica>>(list);
            
        }
    }
}
