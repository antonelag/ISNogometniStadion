using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WebAPI.Database;
using ISNogometniStadion.WebAPI.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace ISNogometniStadion.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly ISNogometniStadionContext _ISNogometniStadionContext;
        private readonly IMapper _mapper;
        public KorisniciService(ISNogometniStadionContext context, IMapper mapper)
        {
            _ISNogometniStadionContext = context;
            _mapper = mapper;
        }

        public string Delete(int id)
        {
            var t = _ISNogometniStadionContext.Korisnici.FirstOrDefault(r => r.KorisnikID == id);
            if (t != null)
            {
                _ISNogometniStadionContext.Remove(t);
                _ISNogometniStadionContext.SaveChanges();
                return "Uspjesno obrisano";
            }
            else
                throw new UserException("Korisnik nije pronadjen");
        }

        public List<Korisnik> Get()
        {
            //return _ISNogometniStadionContext.Korisnici.ToList();
            var list = _ISNogometniStadionContext.Korisnici.ToList();
            return _mapper.Map<List<Model.Korisnik>>(list);
        }

        public Korisnik GetById(int id)
        {
            var t = _ISNogometniStadionContext.Korisnici.FirstOrDefault(s => s.KorisnikID == id);
            if (t != null)
                return _mapper.Map<Model.Korisnik>(t);
            else
                throw new UserException("Korisnik ne postoji");
        }

        public Korisnik Insert(KorisniciInsertRequest req)
        {
            //mapiraju se korisnici u bazu iz zahtjeva
            var entity = _mapper.Map<Database.Korisnici>(req);
            entity.GradID = 1;
            if (req.lozinka != req.potvrdaLozinke)
            {
                //napraviti folder filters sa klasom errorfilter
                //napraviti folter exception u kojem napravimo prazni userexception
                //includamo taj exception u prethodno napravljeni filter
                //pozovemo ga ovdje
                throw new UserException("Lozinke se ne slazu!");
            }
            _ISNogometniStadionContext.Add(entity);
            _ISNogometniStadionContext.SaveChanges();

            return _mapper.Map<Model.Korisnik>(entity);
        }
        public Korisnik Update(int id, KorisniciUpdateRequest req)
        {
                var t = _ISNogometniStadionContext.Korisnici.FirstOrDefault(s => s.KorisnikID == id);
                var g = _ISNogometniStadionContext.Gradovi.FirstOrDefault(s => s.GradID == req.GradID);
            
            if (t!=null && g!=null)
            {
                    _mapper.Map<KorisniciUpdateRequest,Database.Korisnici>(req,t);
                    _ISNogometniStadionContext.SaveChanges();
                    return _mapper.Map<Model.Korisnik>(t);
            }
            else
                throw new UserException("Pogresan unos");
        }
    
    }
}
