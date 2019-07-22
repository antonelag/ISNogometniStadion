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
    public class TribineService : ITribineService
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;
        public TribineService (ISNogometniStadionContext iSNogometniStadionContext, IMapper mapper)
        {
            _context = iSNogometniStadionContext;
            _mapper = mapper;
        }
        public string Delete(int id)
        {
            var t = _context.Tribine.FirstOrDefault(s => s.TribinaID == id);
            if (t != null)
            {
                _context.Tribine.Remove(t);
                _context.SaveChanges();
                return "Uspjesno obrisano!";
            }
            else
                throw new UserException("Tribina ne postoji!");
        }

        public List<Tribina> Get()
        {
            var list = _context.Tribine.ToList();
            return _mapper.Map<List<Tribina>>(list);
        }

        public Tribina GetById(int id)
        {
            var t = _context.Tribine.FirstOrDefault(s => s.TribinaID == id);
            if (t != null)
               return  _mapper.Map<Tribina>(t);
            else
                throw new UserException("Tribina ne postoji!");
        }

        public Tribina Insert(TribineInsertRequest req)
        {
            var i = _context.Tribine.FirstOrDefault(s => s.Naziv == req.Naziv && s.StadionID==req.StadionID);
            var a = _context.Stadioni.FirstOrDefault(s => s.StadionID == req.StadionID);
            if (i == null && a != null)
            {
                var e = _mapper.Map<Database.Tribine>(req);
                _context.Tribine.Add(e);
                _context.SaveChanges();
                return _mapper.Map<Tribina>(e);
            }
            else
                throw new UserException("Pogresan unos");
        }

        public Tribina Update(int id, TribineInsertRequest req)
        {
            var a = _context.Tribine.FirstOrDefault(s => s.Naziv == req.Naziv && s.TribinaID!=id && s.StadionID==req.StadionID);
            var b = _context.Stadioni.FirstOrDefault(s => s.StadionID == req.StadionID);
            var c = _context.Tribine.FirstOrDefault(s => s.TribinaID == id);
            if (a == null && b != null && c != null)
            {
                _mapper.Map<TribineInsertRequest, Database.Tribine>(req, c);
                _context.SaveChanges();
                return _mapper.Map<Tribina>(c);
            }
            else
                throw new UserException("Pogresan unos!");

        }
    }
}
