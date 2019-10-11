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
    public class StadioniService : BaseCRUDService<Model.Stadion, Model.StadioniSearchRequest, Database.Stadioni, StadioniInsertRequest, StadioniInsertRequest>
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;

        public StadioniService(IMapper mapper, ISNogometniStadionContext context) : base(mapper, context)
        {
            _context = context;
            _mapper = mapper;

        }
        public override List<Stadion> Get(StadioniSearchRequest search)
        {
            var q = _context.Set<Database.Stadioni>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv) && search?.GradID.HasValue == true)
            {
                q = q.Where(s => s.Naziv.StartsWith(search.Naziv) && s.GradID == search.GradID);
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(search?.Naziv))
                {
                    q = q.Where(s => s.Naziv.StartsWith(search.Naziv));
                }
                if (search?.GradID.HasValue == true)
                {
                    q = q.Where(s => (s.GradID == search.GradID));
                }
            }
            var list = q.ToList();
            return _mapper.Map<List<Stadion>>(list);

        }
    }
}
