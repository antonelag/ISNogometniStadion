using AutoMapper;
using ISNogometniStadion.WebAPI.Database;
using ISNogometniStadion.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Services
{
    public class BaseService<TModel, TSearch, TDatabase> : IService<TModel, TSearch> where TDatabase : class
    {
        //tdatabase sluzi da kazemo ef s kojom tabelom radimo
        //da se zna s kojim objektom radi ... :class
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;
        public BaseService(IMapper mapper, ISNogometniStadionContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual List<TModel> Get(TSearch search)
        {
            var list = _context.Set<TDatabase>().ToList();


            return _mapper.Map<List<TModel>>(list);
        }

        public virtual
            TModel GetById(int id)
        {
            var e = _context.Set<TDatabase>().Find(id);
            return _mapper.Map<TModel>(e);
        }

    }
}
