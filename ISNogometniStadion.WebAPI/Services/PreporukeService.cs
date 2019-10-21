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
    public class PreporukeService : BaseCRUDService<Model.Preporuka, PreporukaSearchRequest, Database.Preporuke, PreporukaInsertRequest, PreporukaInsertRequest>
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;

        public PreporukeService(IMapper mapper, ISNogometniStadionContext context) : base(mapper, context)
        {
            _context = context;
            _mapper = mapper;

        }
        public override List<Preporuka> Get(PreporukaSearchRequest search)
        {
            var q = _context.Set<Database.Preporuke>().AsQueryable();

            if (search?.KorisnikID.HasValue == true)
            {
                q = q.Where(s => s.KorisnikID == search.KorisnikID).OrderByDescending(s => s.BrojKupljenihUlaznica);
            }
            if (search?.KorisnikID.HasValue == true && search?.PrviTimID.HasValue == true && search?.DrugiTimID.HasValue == true)
            {
                q = q.Where(s => s.KorisnikID == search.KorisnikID && (s.TimID == search.PrviTimID || s.TimID == search.DrugiTimID));
            }
            var list = q.ToList();
            return _mapper.Map<List<Preporuka>>(list);

        }
    }
}
