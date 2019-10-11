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
    public class LigeService : BaseCRUDService<Model.Liga, Model.LigaSearchRequest, Database.Lige,LigaInsertRequest,LigaInsertRequest>
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;

        public LigeService(IMapper mapper, ISNogometniStadionContext context) : base(mapper, context)
        {
            _context = context;
            _mapper = mapper;

        }
        public override List<Liga> Get(LigaSearchRequest search)
        {
            var q = _context.Set<Database.Lige>().AsQueryable();
            if (!string.IsNullOrEmpty(search?.Naziv))
            {
                q = q.Where(s => s.Naziv.StartsWith(search.Naziv));
            }
            if (search?.DrzavaID.HasValue==true)
            {
                q = q.Where(s => s.Drzava.DrzavaID == search.DrzavaID);
            }
            var list = q.ToList();
            return _mapper.Map<List<Liga>>(list);
            
        }
    }
}
