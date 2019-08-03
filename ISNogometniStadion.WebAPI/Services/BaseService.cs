using AutoMapper;
using ISNogometniStadion.WebAPI.Database;
using ISNogometniStadion.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Services
{
    public class BaseService<TModel, TSearch, TDatabase> : IService<TModel, TSearch> where TDatabase:class
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

        //public string Delete(int id)
        //{
        //    var t = _context.Set<TDatabase>().Find(id);
        //    if (t != null)
        //    {
        //        _context.Set<TDatabase>().Remove(t);
        //        _context.SaveChanges();
        //        return "Uspjesno obrisano!";
        //    }
        //    else
        //        throw new UserException("Pogresan unos");
        //}

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

        //public TModel Insert(TInsert req)
        //{
        //        var t = _mapper.Map<TDatabase>(req);
        //        _context.Add(t);
        //        _context.SaveChanges();
        //        return _mapper.Map<TModel>(t);
        //}

        //public TModel Update(int id, TInsert req)
        //{
        //    var t = _context.Set<TDatabase>().Find(id);

        //    if (t != null)
        //    {
        //        _mapper.Map<TInsert,TDatabase>(req, t);
        //        _context.SaveChanges();
        //        return _mapper.Map<TModel>(t);
        //    }
        //    else
        //        throw new UserException("Pogresan unos!");
        //}
        
    }
}
