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
    public class DrzaveService : IDrzaveService
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;
        public DrzaveService(IMapper mapper, ISNogometniStadionContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        public string Delete(int id)
        {
            var t = _context.Drzave.FirstOrDefault(r => r.DrzavaID == id);
            if (t != null)
            {
                _context.Drzave.Remove(t);
                _context.SaveChanges();
                return "Uspjesno obrisano!";
            }
            else
                throw new UserException("Pogresan unos");
        }

        public List<Drzava> Get()
        {
            var list= _context.Drzave.ToList();
            return _mapper.Map<List<Drzava>>(list);
        }

        public Drzava GetById(int id)
        {
            var t = _context.Drzave.FirstOrDefault(s => s.DrzavaID == id);
            if (t != null)
            {
                return _mapper.Map<Drzava>(t);
            }
            else
                throw new UserException("Drzava ne postoji!");
        }

        public Drzava Insert(GradoviUpdateRequest req)
        {
            var a = _context.Drzave.FirstOrDefault(r => r.Naziv.ToLower() == req.Naziv.ToLower());
            if (a == null)
            {
                var t = _mapper.Map<Database.Drzave>(req);
                _context.Add(t);
                _context.SaveChanges();
                return _mapper.Map<Model.Drzava>(t);
            }
            else
                throw new UserException("Drzava sa istim imenom vec postoji!");
        }

        public Drzava Update(int id,DrzaveUpdateRequest req)
        {
            var t = _context.Drzave.FirstOrDefault(r => r.DrzavaID == id);
            var a = _context.Drzave.FirstOrDefault(s => s.Naziv == req.naziv);
            if (t != null && a==null)
            {
                _mapper.Map<DrzaveUpdateRequest, Database.Drzave>(req, t);
                _context.SaveChanges();
                return _mapper.Map<Drzava>(t);
            }
            else
                throw new UserException("Pogresan unos!");
        }
    }
}
