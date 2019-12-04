using AutoMapper;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Services
{
    public class PreporukePoLokacijiService : BaseCRUDService<Model.PreporukaPoLokaciji, PreporukaSearchRequest, Database.PreporukePoLokaciji, PreporukePoLokacijiInsertRequest, PreporukePoLokacijiInsertRequest>
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;

        public PreporukePoLokacijiService(ISNogometniStadionContext context, IMapper mapper):base(mapper,context)
        {
            _context = context;
            _mapper = mapper;
        }

        public override List<Model.PreporukaPoLokaciji> Get(PreporukaSearchRequest search)
        {
            var q = _context.Set<Database.PreporukePoLokaciji>().AsQueryable();

            if (search?.KorisnikID.HasValue == true)
            {
                q = q.Where(s => s.KorisnikID == search.KorisnikID);
            }
           
            var list = q.ToList();
            return _mapper.Map<List<Model.PreporukaPoLokaciji>>(list);

        }
    }
}
