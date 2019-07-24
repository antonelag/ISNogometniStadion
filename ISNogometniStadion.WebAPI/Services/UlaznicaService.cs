using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WebAPI.Database;
using ISNogometniStadion.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace ISNogometniStadion.WebAPI.Services
{
    public class UlaznicaService : IUlaznicaService
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;
        public UlaznicaService(ISNogometniStadionContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public string Delete(int id)
        {
            var t = _context.Ulaznice.FirstOrDefault(s => s.UlaznicaID == id);
            if (t != null)
            {
                _context.Ulaznice.Remove(t);
                _context.SaveChanges();
                return "Uspjesno obrisano!";
            }
            else throw new UserException("Ulaznica ne postoji");
        }

        public List<Ulaznica> Get(UlazniceSearchRequest req)
        {
           // var q = _context.Ulaznice.AsQueryable();
            var q = _context.Ulaznice.AsQueryable();
            if (!string.IsNullOrEmpty(req?.ImePrezime))
            {
                q=q.Include(s=>s.Korisnik)
                 .Where(c => (c.Korisnik.Ime.StartsWith(req.ImePrezime)) || c.Korisnik.Prezime.StartsWith(req.ImePrezime));
            }

            var list = q.ToList();
            return _mapper.Map<List<Ulaznica>>(list);
        }

        public Ulaznica GetById(int id)
        {
            var t = _context.Ulaznice.FirstOrDefault(s => s.UlaznicaID == id);
            if (t != null)
            {
                return _mapper.Map<Ulaznica>(t);
            }
            else throw new UserException("Ulaznica ne postoji");

        }

        public Ulaznica Insert(UlazniceInsertRequest req)
        {
            var s = _context.Ulaznice.FirstOrDefault(e => e.SjedaloID == req.SjedaloID && e.UtakmicaID == req.UtakmicaID);
            var a = _context.Sjedala.FirstOrDefault(c => c.SjedaloID == req.SjedaloID);
            var d = _context.Utakmice.FirstOrDefault(e => e.UtakmicaID == req.UtakmicaID);
            var p = _context.Korisnici.FirstOrDefault(r => r.KorisnikID == req.KorisnikID);
            if (s == null && a != null & d != null && p!=null)
            {
                var e = _mapper.Map<Database.Ulaznice>(req);
                _context.Ulaznice.Add(e);
                _context.SaveChanges();
                return _mapper.Map<Ulaznica>(e);
            }
            else throw new UserException("Pogresan unos");
        }

        public Ulaznica Update(int id, UlazniceInsertRequest req)
        {
            var t = _context.Ulaznice.FirstOrDefault(s => s.UlaznicaID == id);
            var a = _context.Sjedala.FirstOrDefault(e => e.SjedaloID == req.SjedaloID);
            var u = _context.Utakmice.FirstOrDefault(e => e.UtakmicaID == req.UtakmicaID);
            var p = _context.Korisnici.FirstOrDefault(r => r.KorisnikID == req.KorisnikID);
            var z = _context.Ulaznice.FirstOrDefault(e => e.SjedaloID == req.SjedaloID && e.UtakmicaID == req.UtakmicaID && e.UlaznicaID!=id);
            if (t != null && a != null && u != null && z == null && p!=null)
            {
                _mapper.Map<UlazniceInsertRequest, Database.Ulaznice>(req, t);
                _context.SaveChanges();
                return _mapper.Map<Ulaznica>(t);
            }
            else
                throw new UserException("Pogresan unos");
        }
    }
}
