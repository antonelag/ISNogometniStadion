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
    public class GradService : BaseCRUDService<Model.Grad, Model.GradoviSearchRequest, Database.Gradovi, GradoviInsertRequest, GradoviInsertRequest>
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;

        public GradService(IMapper mapper, ISNogometniStadionContext context) : base(mapper, context)
        {
            _context = context;
            _mapper = mapper;

        }
        public override List<Grad> Get(GradoviSearchRequest search)
            {
            var q = _context.Set<Database.Gradovi>().AsQueryable();

            if (!string.IsNullOrEmpty(search?.Naziv) && search?.DrzavaID.HasValue == true)
            {
                q = q.Where(s => s.Naziv.StartsWith(search.Naziv) && s.DrzavaID == search.DrzavaID);
            }
            else
            {
                if (!string.IsNullOrEmpty(search?.Naziv))
                {
                    q = q.Where(s => s.Naziv.StartsWith(search.Naziv));
                }
                if (search?.DrzavaID.HasValue == true)
                {
                    q = q.Where(s => s.DrzavaID == search.DrzavaID);
                }
            }
            var list = q.ToList();

            return _mapper.Map<List<Grad>>(list);

        }
    }
}
