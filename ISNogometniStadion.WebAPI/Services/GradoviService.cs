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
    public class GradoviService : IGradoviService
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;
        public GradoviService(IMapper mapper, ISNogometniStadionContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        public string Delete(int id)
        {
            var t = _context.Gradovi.FirstOrDefault(r => r.GradID == id);
            if (t != null)
            {
                _context.Gradovi.Remove(t);
                _context.SaveChanges();
                return "Uspjesno obrisano!";
            }
            else
                throw new UserException("Pogresan unos");
        }

        public List<Grad> Get()
        {
            var list= _context.Gradovi.ToList();
            return _mapper.Map<List<Grad>>(list);
        }

        public Grad GetById(int id)
        {
            var t = _context.Gradovi.FirstOrDefault(s => s.GradID == id);
            if (t != null)
            {
                return _mapper.Map<Grad>(t);
            }
            else
                throw new UserException("Grad ne postoji!");
        }

        public Grad Insert(GradoviInsertRequest req)
        {
            var a = _context.Gradovi.FirstOrDefault(r => r.Naziv.ToLower() == req.Naziv.ToLower());
            var g = _context.Drzave.FirstOrDefault(s => s.DrzavaID == req.DrzavaID);
            if (a == null && g!=null)
            {
                var t = _mapper.Map<Database.Gradovi>(req);
                _context.Add(t);
                _context.SaveChanges();
                return _mapper.Map<Model.Grad>(t);
            }
            else
                throw new UserException("Pogresan unos!");
        }

        public Grad Update(int id,GradoviUpdateRequest req)
        {
            var t = _context.Gradovi.FirstOrDefault(r => r.GradID == id);
            var g = _context.Drzave.FirstOrDefault(s => s.DrzavaID == req.DrzavaID);
            var a = _context.Gradovi.FirstOrDefault(e => e.Naziv == req.Naziv);

            if (t != null && g != null && a == null) 
            {
                _mapper.Map<GradoviUpdateRequest, Database.Gradovi>(req, t);
                _context.SaveChanges();
                return _mapper.Map<Grad>(t);
            }
            else
                throw new UserException("Pogresan unos!");
        }
    }
}
