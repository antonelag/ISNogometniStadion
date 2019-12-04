using AutoMapper;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Services
{
    public class PreporukePoTimuService : BaseCRUDService<Model.PreporukaPoTimu, PreporukaSearchRequest, Database.PreporukePoTimu, PreporukePoTimuInsertRequest, PreporukePoTimuInsertRequest>
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;

        public PreporukePoTimuService(IMapper mapper, ISNogometniStadionContext context) : base(mapper, context)
        {
            _context = context;
            _mapper = mapper;
        }

        public override List<Model.PreporukaPoTimu> Get(PreporukaSearchRequest search)
        {
            var q = _context.Set<Database.PreporukePoTimu>().AsQueryable();

            if (search?.KorisnikID.HasValue == true)
            {
                q = q.Where(s => s.KorisnikID == search.KorisnikID);
            }

            var list = q.ToList();
            return _mapper.Map<List<Model.PreporukaPoTimu>>(list);

        }
    }
}
