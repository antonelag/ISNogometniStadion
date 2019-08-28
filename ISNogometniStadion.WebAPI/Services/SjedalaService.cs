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
    public class SjedalaService : BaseCRUDService<Model.Sjedalo, Model.SjedalaSearchRequest, Database.Sjedala,SjedalaInsertRequest, SjedalaInsertRequest>
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;

        public SjedalaService(IMapper mapper, ISNogometniStadionContext context) : base(mapper, context)
        {
            _context = context;
            _mapper = mapper;

        }
        public override List<Sjedalo> Get(SjedalaSearchRequest search)
        {
            var q = _context.Set<Database.Sjedala>().AsQueryable();
            if (!string.IsNullOrEmpty(search?.Oznaka))
            {
                q = q.Where(s => (s.Oznaka.StartsWith(search.Oznaka)));
            }
            var list = q.ToList();
            return _mapper.Map<List<Sjedalo>>(list);
            
        }
    }
}
