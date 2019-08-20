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
    public class TimoviService : BaseCRUDService<Model.Tim, Model.TimoviSearchRequest, Database.Timovi,TimoviInsertRequest, TimoviInsertRequest>
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;

        public TimoviService(IMapper mapper, ISNogometniStadionContext context) : base(mapper, context)
        {
            _context = context;
            _mapper = mapper;

        }
        public override List<Tim> Get(TimoviSearchRequest search)
        {
            var q = _context.Set<Database.Timovi>().AsQueryable();

            if (search.LigaID.HasValue)
            {
                q = q.Where(s => s.LigaID==search.LigaID);
            }
            var list = q.ToList();
            return _mapper.Map<List<Tim>>(list);
            
        }
    }
}
