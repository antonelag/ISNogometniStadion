using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ISNogometniStadion.WebAPI.Database;

namespace ISNogometniStadion.WebAPI.Services
{
    public class BaseCRUDService<TModel, TSearch, TDatabase, TInsert, TUpdate> : BaseService<TModel, TSearch, TDatabase>, ICRUDService<TModel, TSearch, TInsert, TUpdate> where TDatabase:class
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;

        public BaseCRUDService(IMapper mapper, ISNogometniStadionContext context) : base(mapper, context)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual TModel Insert(TInsert req)
        {
            var t = _mapper.Map<TDatabase>(req);
            _context.Add(t);
            _context.SaveChanges();
            return _mapper.Map<TModel>(t);
        }

        public TModel Update(int id, TUpdate req)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);
            _mapper.Map(req, entity);
            _context.SaveChanges();
            return _mapper.Map<TModel>(entity);
        }
    }
}
