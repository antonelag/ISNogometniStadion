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
    public class DrzaveService : BaseCRUDService<Model.Drzava, Model.DrzaveSearchRequest, Database.Drzave, DrzaveInsertRequest, DrzaveInsertRequest>
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;

        public DrzaveService(IMapper mapper, ISNogometniStadionContext context) : base(mapper, context)
        {
            _context = context;
            _mapper = mapper;

        }
        public override List<Drzava> Get(DrzaveSearchRequest search)
        {
            var q = _context.Set<Database.Drzave>().AsQueryable();

            if (!string.IsNullOrEmpty(search?.Naziv))
            {
                q = q.Where(s => s.Naziv.StartsWith(search.Naziv));
            }
            var list = q.ToList();
            return _mapper.Map<List<Drzava>>(list);

        }
    }
}
