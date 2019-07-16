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
    public class KorisniciService : IKorisniciService
    {
        private readonly ISNogometniStadionContext _ISNogometniStadionContext;
        private readonly IMapper    _mapper;
        public KorisniciService(ISNogometniStadionContext context, IMapper mapper)
        {
            _ISNogometniStadionContext = context;
            _mapper = mapper;
        }
        public List<Korisnik> Get()
        {
            //return _ISNogometniStadionContext.Korisnici.ToList();
            var list = _ISNogometniStadionContext.Korisnici.ToList();
            return _mapper.Map<List<Model.Korisnik>>(list);
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
    }
}
