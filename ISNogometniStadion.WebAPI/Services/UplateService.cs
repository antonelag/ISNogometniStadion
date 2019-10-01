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
    public class UplateService : BaseCRUDService<Model.Uplata, Model.UplateSearchRequest, Database.Uplate,UplateInsertRequest, UplateInsertRequest>
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;
        public UplateService(IMapper mapper, ISNogometniStadionContext context) : base(mapper, context)
        {
            _context = context;
            _mapper = mapper;

        }
        public override List<Uplata> Get(UplateSearchRequest search)
        {
            var q = _context.Set<Database.Uplate>().AsQueryable();

            if (search?.UtakmicaID.HasValue == true)
            {
                int i = (int)search.UtakmicaID;
                List<Utakmica> lista = _mapper.Map<List<Utakmica>>(_context.Set<Database.Utakmice>().ToList());

                Utakmica utakmica = null;
                foreach(var u in lista)
                {
                    if (u.UtakmicaID == search.UtakmicaID)
                        utakmica = u;
                }

                var id = utakmica.UtakmicaID;
                q = q.Where(s => s.Ulaznica.UtakmicaID == id);
            }

            var list = q.ToList();
            return _mapper.Map<List<Uplata>>(list);
        }
    }
}
