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
    public class UtakmiceService:IUtakmiceService
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;
        public UtakmiceService(ISNogometniStadionContext iSNogometniStadionContext, IMapper mapper)
        {
            _context = iSNogometniStadionContext;
            _mapper = mapper;
        }

        public string Delete(int id)
        {
            var t = _context.Utakmice.FirstOrDefault(s => s.UtakmicaID == id);
            if (t != null)
            {
                _context.Utakmice.Remove(t);
                _context.SaveChanges();
                return "Uspjesno obrisano!";
            }
            else
                throw new UserException("Utakmica nije pronadjena!");
        }

        public List<Utakmica> Get()
        {
            var list = _context.Utakmice.ToList();
            return _mapper.Map<List<Utakmica>>(list);
            
        }

        public Utakmica GetById(int id)
        {
            var t = _context.Utakmice.FirstOrDefault(s => s.UtakmicaID == id);
            if (t != null)
            {
                return _mapper.Map<Utakmica>(t);
            }
            else
                throw new UserException("Utakmica nije pronadjena!");
        }

        public Utakmica Insert(UtakmiceInsertRequest req)
        {
          
            var isti = _context.Utakmice.FirstOrDefault(a => a.DomaciTimID == req.DomaciTimID && a.GostujuciTimID == req.GostujuciTimID && DateTime.Compare(a.DatumOdigravanja, req.DatumOdigravanja) == 0 && DateTime.Compare(a.VrijemeOdigravanja, req.VrijemeOdigravanja) == 0);
            var zamjena = _context.Utakmice.FirstOrDefault(a => a.DomaciTimID == req.GostujuciTimID && a.GostujuciTimID == req.DomaciTimID && DateTime.Compare(a.DatumOdigravanja, req.DatumOdigravanja) == 0);
            bool istiTim = req.DomaciTimID == req.GostujuciTimID ? true : false;
            var d = _context.Timovi.FirstOrDefault(f => f.TimID == req.DomaciTimID);
            var e = _context.Timovi.FirstOrDefault(f => f.TimID == req.GostujuciTimID);
            var p = _context.Stadioni.FirstOrDefault(f => f.StadionID == req.StadionID);


            if (isti == null &&zamjena==null && !istiTim&& d != null && e != null && p != null) 
            {
                var a = _mapper.Map<Utakmice>(req);
                _context.Utakmice.Add(a);
                _context.SaveChanges();
                return _mapper.Map<Utakmica>(a);
            }
            else
                throw new UserException("Pogresan unos!");
        }

        public Utakmica Update(int id, UtakmiceInsertRequest req)
        {
            var t = _context.Utakmice.FirstOrDefault(s => s.UtakmicaID == id);
            bool istiTim=req.DomaciTimID == req.GostujuciTimID?true:false;
            var d = _context.Timovi.FirstOrDefault(f => f.TimID == req.DomaciTimID);
            var e = _context.Timovi.FirstOrDefault(f => f.TimID == req.GostujuciTimID);
            var p = _context.Stadioni.FirstOrDefault(f => f.StadionID == req.StadionID);
            var isti = _context.Utakmice.FirstOrDefault(a => a.DomaciTimID == req.DomaciTimID && a.GostujuciTimID == req.GostujuciTimID && DateTime.Compare(a.DatumOdigravanja, req.DatumOdigravanja)==0 && a.UtakmicaID != id);
            if (isti==null && t != null && !istiTim && d!=null && p!=null && e!=null)
            {
                _mapper.Map<UtakmiceInsertRequest, Utakmice>(req, t);
                _context.SaveChanges();
                return _mapper.Map<Utakmica>(t);
            }
            else
                throw new UserException("Pogresan unos!");
        }
    }
}
