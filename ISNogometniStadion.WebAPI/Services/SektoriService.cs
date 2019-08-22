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
    public class SektoriService : BaseCRUDService<Model.Sektor, Model.SektoriSearchRequest, Database.Sektori,SektoriInsertRequest, SektoriInsertRequest>
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;

        public SektoriService(IMapper mapper, ISNogometniStadionContext context) : base(mapper, context)
        {
            _context = context;
            _mapper = mapper;

        }
        public override List<Sektor> Get(SektoriSearchRequest search)
        {
            var q = _context.Set<Database.Sektori>().AsQueryable();

            if (search.TribinaID.HasValue)
            {
                q = q.Where(s => (s.TribinaID==search.TribinaID));
            }
            var list = q.ToList();
            return _mapper.Map<List<Sektor>>(list);
            
        }
    }
}
