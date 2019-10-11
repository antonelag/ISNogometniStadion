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
    public class TribineService : BaseCRUDService<Model.Tribina, Model.TribineSearchRequest, Database.Tribine,TribineInsertRequest, TribineInsertRequest>
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;

        public TribineService(IMapper mapper, ISNogometniStadionContext context) : base(mapper, context)
        {
            _context = context;
            _mapper = mapper;

        }
        public override List<Tribina> Get(TribineSearchRequest search)
        {
            var q = _context.Set<Database.Tribine>().AsQueryable();
           
            if (!string.IsNullOrEmpty(search?.Naziv))
            {
                q = q.Where(s => (s.Naziv.StartsWith(search.Naziv)));
            }
            if (search?.StadionID.HasValue == true)
            {
                q = q.Where(s => s.StadionID == search.StadionID);
            }
            var list = q.ToList();
            return _mapper.Map<List<Tribina>>(list);
            
        }
    }
}
