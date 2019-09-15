using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WebAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace ISNogometniStadion.WebAPI.Services
{
    public class UtakmiceService : BaseCRUDService<Model.Utakmica, Model.UtakmiceeSearchRequest, Database.Utakmice,UtakmiceInsertRequest, UtakmiceInsertRequest>
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;

        public UtakmiceService(IMapper mapper, ISNogometniStadionContext context) : base(mapper, context)
        {
            _context = context;
            _mapper = mapper;

        }
        public override List<Utakmica> Get(UtakmiceeSearchRequest search)
        {
            var q = _context.Set<Database.Utakmice>().AsQueryable();
            q=q.Where(s=>s.DatumOdigravanja.Date>=DateTime.Now.Date);
            if (search?.LigaID.HasValue == true)
            {
                q = q.Where(s => s.LigaID == search.LigaID);
            }
            if (search?.StadionID.HasValue == true)
            {
                q = q.Where(s => s.StadionID == search.StadionID);
            }
            var list = q.ToList();
            return _mapper.Map<List<Utakmica>>(list);
            
        }
    }
}
