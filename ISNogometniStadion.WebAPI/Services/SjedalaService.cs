using AutoMapper;
using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WebAPI.Database;
using ISNogometniStadion.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISNogometniStadion.WebAPI.Services
{
    public class SjedalaService:ISjedalaService
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;
        public SjedalaService(ISNogometniStadionContext iSNogometniStadionContext, IMapper mapper)
        {
            _context = iSNogometniStadionContext;
            _mapper = mapper;
        }

        public string Delete(int id)
        {
            var t = _context.Sjedala.FirstOrDefault(r => r.SjedaloID == id);
            if (t != null)
            {
                _context.Sjedala.Remove(t);
                _context.SaveChanges();
                return "Uspjesno obrisano";
            }
            else
                throw new UserException("Sjedalo nije pronadjeno!");
        }

        public List<Sjedalo> Get(SjedalaSearchRequest req)
        {
            var     q = _context.Sjedala.AsQueryable();
            if (!string.IsNullOrEmpty(req?.Oznaka))
            {
                q = q.Where(s => s.Oznaka.StartsWith(req.Oznaka));
            }
            var list = q.ToList();

            return _mapper.Map <List<Sjedalo>>(list);
        }

        public Sjedalo GetById(int id)
        {
            var t = _context.Sjedala.FirstOrDefault(r => r.SjedaloID == id);
            if (t != null)
                return _mapper.Map<Sjedalo>(t);
            else
                throw new UserException("Sjedalo nije pronadjeno!");
        }

        public Sjedalo Insert(SjedalaInsertRequest req)
        {
            var s = _context.Sjedala.FirstOrDefault(a => a.Oznaka == req.Oznaka && a.TribinaID == req.TribinaID);
            var b = _context.Tribine.FirstOrDefault(r => r.TribinaID == req.TribinaID);
            if (s == null && b!=null)
            {
                var e = _mapper.Map<Sjedala>(req);
                _context.Sjedala.Add(e);
                _context.SaveChanges();
                return _mapper.Map<Sjedalo>(e);

            }
            else
                throw new UserException("Pogresan unos!");
        }

        public Sjedalo Update(int id, SjedalaInsertRequest req)
        {
            var t = _context.Sjedala.FirstOrDefault(r => r.SjedaloID == id);
            var s = _context.Sjedala.FirstOrDefault(a => a.Oznaka == req.Oznaka && a.TribinaID == req.TribinaID && a.SjedaloID!=id);
            var b = _context.Tribine.FirstOrDefault(r => r.TribinaID == req.TribinaID);

            if (t != null && s == null && b!=null)
            {
                _mapper.Map<SjedalaInsertRequest, Sjedala>(req, t);
                _context.SaveChanges();
                return _mapper.Map<Sjedalo>(t);
            }
            else
                throw new UserException("Pogresan unos!");

        }
    }
}
