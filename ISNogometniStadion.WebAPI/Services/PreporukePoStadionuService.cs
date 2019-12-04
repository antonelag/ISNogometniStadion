using AutoMapper;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Services
{
    public class PreporukePoStadionuService : BaseCRUDService<Model.PreporukaPoStadionu, PreporukaSearchRequest, Database.PreporukePoStadionu, PreporukePoStadionuInsertRequest, PreporukePoStadionuInsertRequest>
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;

        public PreporukePoStadionuService(IMapper mapper, ISNogometniStadionContext context) : base(mapper, context)
        {
            _context = context;
            _mapper = mapper;
        }
        public override List<Model.PreporukaPoStadionu> Get(PreporukaSearchRequest search)
        {
            var q = _context.Set<Database.PreporukePoStadionu>().AsQueryable();

            if (search?.KorisnikID.HasValue == true)
            {
                q = q.Where(s => s.KorisnikID == search.KorisnikID);
            }

            var list = q.ToList();
            return _mapper.Map<List<Model.PreporukaPoStadionu>>(list);

        }
    }
}
