using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WebAPI.Database;
using ISNogometniStadion.WebAPI.Exceptions;

namespace ISNogometniStadion.WebAPI.Services
{
    public class StadioniService : IStadioniService
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;
        public StadioniService(ISNogometniStadionContext iSNogometniStadionContext, IMapper mapper)
        {
            _context = iSNogometniStadionContext;
            _mapper = mapper;
        }
        public string Delete(int id)
        {
            var t = _context.Stadioni.FirstOrDefault(s => s.StadionID == id);
            if (t != null)
            {
                _context.Stadioni.Remove(t);
                _context.SaveChanges();
                return "Uspjesno obrisano!";
            }
            else
                throw new UserException("Stadion ne postoji!");
        }

        public List<Stadion> Get(StadioniSearchRequest req)
        {
            var q = _context.Stadioni.AsQueryable();
            if (!string.IsNullOrEmpty(req?.Naziv))
            {
                q = q.Where(s => s.Naziv.StartsWith(req.Naziv));
            }
            var list = q.ToList();
            return _mapper.Map<List<Stadion>>(list);
        }

        public Stadion GetById(int id)
        {
            var t = _context.Stadioni.FirstOrDefault(s => s.StadionID == id);
            if (t != null)
                return _mapper.Map<Stadion>(t);
            else
                throw new UserException("Stadion ne postoji!");
        }

        public Stadion Insert(StadioniInsertRequest req)
        {
            var g = _context.Gradovi.FirstOrDefault(s => s.GradID == req.GradID);
            var t = _context.Stadioni.FirstOrDefault(s => s.Naziv == req.Naziv);
            if (t == null && g != null)
            {
                var e = _mapper.Map<Database.Stadioni>(req);
                _context.Stadioni.Add(e);
                _context.SaveChanges();
                return _mapper.Map<Stadion>(e);
            }
            else
                throw new UserException("Pogresan unos");
        }

        public Stadion Update(int id, StadioniInsertRequest req)
        {
            var t = _context.Stadioni.FirstOrDefault(s => s.StadionID == id);
            var a = _context.Stadioni.FirstOrDefault(s => s.Naziv == req.Naziv && s.StadionID!=id);
            var g = _context.Gradovi.FirstOrDefault(s => s.GradID == req.GradID);
            if (t != null && a==null && g!=null)
            {
                _mapper.Map<StadioniInsertRequest, Database.Stadioni>(req, t);
                _context.SaveChanges();
                return _mapper.Map<Stadion>(t);
            }
            else
                throw new UserException("Pogresan unos");
        }
    }
}
