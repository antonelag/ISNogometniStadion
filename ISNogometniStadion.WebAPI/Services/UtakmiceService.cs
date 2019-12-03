using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WebAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace ISNogometniStadion.WebAPI.Services
{
    public class UtakmiceService : BaseCRUDService<Model.Utakmica, Model.UtakmiceeSearchRequest, Database.Utakmice, UtakmiceInsertRequest, UtakmiceInsertRequest>
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;

        public UtakmiceService(IMapper mapper, ISNogometniStadionContext context) : base(mapper, context)
        {
            _context = context;
            _mapper = mapper;

        }
        public override List<Utakmica> Get(UtakmiceeSearchRequest search)
        {
            var q = _context.Set<Database.Utakmice>().AsQueryable();
            if (!search.sveUtakmice)
                q = q.Where(s => s.DatumOdigravanja.Date >= DateTime.Now.Date);
            if (search.PoTimu && search?.cijena.HasValue == true && (search.LigaID.HasValue == true || search.TimID.HasValue == true) && search?.d1 != null && search?.d2 != null)
            {
                var tribine = new List<Tribine>();
                    tribine = _context.Tribine.Where(s => s.Cijena <= search.cijena).ToList();

                var sektori = _context.Sektori.Where(a => tribine.Any(s => s.TribinaID == a.TribinaID)).ToList();
                var sjedala = _context.Sjedala.Where(a => sektori.Any(s => s.SektorID == a.SektorID) && a.Status == false).ToList();

                if (sjedala.Count != 0)
                {
                    if (search.LigaID.HasValue == true)
                        q = q.Where(s => tribine.Any(a => a.StadionID == s.StadionID) && s.LigaID== search.LigaID);
                    if (search.TimID.HasValue == true)
                        q = q.Where(s => tribine.Any(a => a.StadionID == s.StadionID) && (s.DomaciTimID==search.TimID || s.GostujuciTimID==search.TimID));

                    q = q.Where(s => s.DatumOdigravanja > search.d1 && s.DatumOdigravanja < search.d2);
                    List<Utakmica> lista = _mapper.Map<List<Utakmica>>(q.ToList().Distinct());
                    return lista;
                }
                else//ili vrati praznu
                    return new List<Utakmica>();
            }
            else if (search.PoTimu && search?.cijena.HasValue == true && (search.LigaID.HasValue == true || search.TimID.HasValue == true))
            {
                var tribine = new List<Tribine>();
                    tribine = _context.Tribine.Where(s => s.Cijena <= search.cijena).ToList();
                var sektori = _context.Sektori.Where(a => tribine.Any(s => s.TribinaID == a.TribinaID)).ToList();
                var sjedala = _context.Sjedala.Where(a => sektori.Any(s => s.SektorID == a.SektorID) && a.Status == false).ToList();

                if (sjedala.Count != 0)
                {
                    if (search.LigaID.HasValue == true)
                        q = q.Where(s => tribine.Any(a => a.StadionID == s.StadionID) && s.LigaID == search.LigaID);
                    if (search.TimID.HasValue == true)
                        q = q.Where(s => tribine.Any(a => a.StadionID == s.StadionID) && (s.DomaciTimID == search.TimID || s.GostujuciTimID == search.TimID));
                    List<Utakmica> lista = _mapper.Map<List<Utakmica>>(q.ToList().Distinct());
                    return lista;
                }
                else//ili vrati praznu
                    return new List<Utakmica>();
            }
            else if (search.PoTimu && search?.d1 != null && search?.d2 != null && (search.LigaID.HasValue == true || search.TimID.HasValue == true))
            {
                if (search.LigaID.HasValue == true)
                    q = q.Where(s => s.DatumOdigravanja > search.d1 && s.DatumOdigravanja < search.d2 && s.LigaID == search.LigaID);
                if (search.TimID.HasValue == true)
                    q = q.Where(s => s.DatumOdigravanja > search.d1 && s.DatumOdigravanja < search.d2 && (s.DomaciTimID == search.TimID || s.GostujuciTimID == search.TimID));
                List<Utakmica> lista = _mapper.Map<List<Utakmica>>(q.ToList().Distinct());
                return lista;
            }
            else if (search.PoStadionu && search?.cijena.HasValue == true && (search.DrzavaID.HasValue == true || search.StadionID.HasValue == true) && search?.d1 != null && search?.d2 != null)
            {
                var tribine = new List<Tribine>();
                if (!search.StadionID.HasValue)
                    tribine = _context.Tribine.Where(s => s.Cijena <= search.cijena && q.Any(a => a.StadionID == s.StadionID)).ToList();
                else
                    tribine = _context.Tribine.Where(s => s.Cijena <= search.cijena && s.StadionID==search.StadionID).ToList();

                var sektori = _context.Sektori.Where(a => tribine.Any(s => s.TribinaID == a.TribinaID)).ToList();
                var sjedala = _context.Sjedala.Where(a => sektori.Any(s => s.SektorID == a.SektorID) && a.Status == false).ToList();

                if (sjedala.Count != 0)
                {
                    if (search.DrzavaID.HasValue == true)
                        q = q.Include(s => s.stadion.Grad).Where(s => tribine.Any(a => a.StadionID == s.StadionID) && s.stadion.Grad.DrzavaID == search.DrzavaID);
                    if (search.StadionID.HasValue == true)
                        q = q.Where(s => tribine.Any(a => a.StadionID == s.StadionID));

                    q = q.Where(s => s.DatumOdigravanja > search.d1 && s.DatumOdigravanja < search.d2);
                    List<Utakmica> lista = _mapper.Map<List<Utakmica>>(q.ToList());
                    return lista;
                }
                else//ili vrati praznu
                    return new List<Utakmica>();
            }
            
            else if (search.PoStadionu && search?.cijena.HasValue == true && (search.DrzavaID.HasValue == true || search.StadionID.HasValue == true))
            {
                var tribine = new List<Tribine>();
                if (!search.StadionID.HasValue)
                    tribine = _context.Tribine.Where(s => s.Cijena <= search.cijena && q.Any(a => a.StadionID == s.StadionID)).ToList();
                else
                    tribine = _context.Tribine.Where(s => s.Cijena <= search.cijena && s.StadionID == search.StadionID).ToList();
                var sektori = _context.Sektori.Where(a => tribine.Any(s => s.TribinaID == a.TribinaID)).ToList();
                var sjedala = _context.Sjedala.Where(a => sektori.Any(s => s.SektorID == a.SektorID) && a.Status == false).ToList();

                if (sjedala.Count != 0)
                {
                    if (search.DrzavaID.HasValue == true)
                        q = q.Include(s => s.stadion.Grad).Where(s => tribine.Any(a => a.StadionID == s.StadionID) && s.stadion.Grad.DrzavaID == search.DrzavaID);
                    if (search.StadionID.HasValue == true)
                        q = q.Where(s => tribine.Any(a => a.StadionID == s.StadionID));
                    List<Utakmica> lista = _mapper.Map<List<Utakmica>>(q.ToList());
                    return lista;
                }
                else//ili vrati praznu
                    return new List<Utakmica>();
            }
            else if (search.PoStadionu && search?.d1 != null && search?.d2 != null && (search.DrzavaID.HasValue == true || search.StadionID.HasValue == true))
            {
                if (search.DrzavaID.HasValue == true)
                    q = q.Include(s => s.stadion.Grad).Where(s => s.DatumOdigravanja > search.d1 && s.DatumOdigravanja < search.d2 && s.stadion.Grad.DrzavaID == search.DrzavaID);
                if (search.StadionID.HasValue == true)
                    q = q.Where(s => s.DatumOdigravanja > search.d1 && s.DatumOdigravanja < search.d2 && s.StadionID == search.StadionID);
                List<Utakmica> lista = _mapper.Map<List<Utakmica>>(q.ToList());
                return lista;
            }
            else if (search.PoLokaciji && search?.cijena.HasValue == true && (search.DrzavaID.HasValue == true || search.GradID.HasValue == true) && search?.d1 != null && search?.d2 != null)
            {
                var tribine = _context.Tribine.Where(s => s.Cijena <= search.cijena && q.Any(a => a.StadionID == s.StadionID)).ToList();
                var sektori = _context.Sektori.Where(a => tribine.Any(s => s.TribinaID == a.TribinaID)).ToList();
                var sjedala = _context.Sjedala.Where(a => sektori.Any(s => s.SektorID == a.SektorID) && a.Status == false).ToList();

                if (sjedala.Count != 0)
                {
                    if (search.DrzavaID.HasValue == true)
                        q = q.Include(s => s.stadion.Grad).Where(s => tribine.Any(a => a.StadionID == s.StadionID) && s.stadion.Grad.DrzavaID == search.DrzavaID);
                    if (search.GradID.HasValue == true)
                        q = q.Include(s => s.stadion).Where(s => tribine.Any(a => a.StadionID == s.StadionID) && s.stadion.GradID == search.GradID);

                    q = q.Where(s => s.DatumOdigravanja > search.d1 && s.DatumOdigravanja < search.d2);
                    List<Utakmica> lista = _mapper.Map<List<Utakmica>>(q.ToList());
                    return lista;
                }
                else//ili vrati praznu
                    return new List<Utakmica>();
            }

            else if (search.PoLokaciji && search?.cijena.HasValue == true && (search.DrzavaID.HasValue == true || search.GradID.HasValue == true))
            {
                var tribine = _context.Tribine.Where(s => s.Cijena <= search.cijena && q.Any(a => a.StadionID == s.StadionID)).ToList();
                var sektori = _context.Sektori.Where(a => tribine.Any(s => s.TribinaID == a.TribinaID)).ToList();
                var sjedala = _context.Sjedala.Where(a => sektori.Any(s => s.SektorID == a.SektorID) && a.Status == false).ToList();

                if (sjedala.Count != 0)
                {
                    if (search.DrzavaID.HasValue == true)
                        q = q.Include(s => s.stadion.Grad).Where(s => tribine.Any(a => a.StadionID == s.StadionID) && s.stadion.Grad.DrzavaID == search.DrzavaID);
                    if (search.GradID.HasValue == true)
                        q = q.Include(s => s.stadion).Where(s => tribine.Any(a => a.StadionID == s.StadionID) && s.stadion.GradID == search.GradID);
                    List<Utakmica> lista = _mapper.Map<List<Utakmica>>(q.ToList());
                    return lista;
                }
                else//ili vrati praznu
                    return new List<Utakmica>();
            }
            else if (search.PoLokaciji && search?.d1 != null && search?.d2 != null && (search.DrzavaID.HasValue == true || search.GradID.HasValue == true))
            {
                if (search.DrzavaID.HasValue == true)
                    q = q.Include(s => s.stadion.Grad).Where(s => s.DatumOdigravanja > search.d1 && s.DatumOdigravanja < search.d2 && s.stadion.Grad.DrzavaID == search.DrzavaID);
                if (search.GradID.HasValue == true)
                    q = q.Include(s => s.stadion).Where(s => s.DatumOdigravanja > search.d1 && s.DatumOdigravanja < search.d2 && s.stadion.GradID == search.GradID);
                List<Utakmica> lista = _mapper.Map<List<Utakmica>>(q.ToList());
                return lista;
            }
            else
            {
                if (search?.TimID.HasValue == true)
                {
                    q = q.Where(s => s.DomaciTimID == search.TimID || s.GostujuciTimID == search.TimID);
                }
                if (search?.d1 != null && search?.d2 != null)
                {
                    q = q.Where(s => s.DatumOdigravanja > search.d1 && s.DatumOdigravanja < search.d2);
                }
                if (search?.GradID.HasValue == true)
                {
                    q = q.Include(s => s.stadion).Where(s => s.stadion.GradID == search.GradID);
                }
                if (search?.DrzavaID.HasValue == true)
                {
                    q = q.Include(s => s.stadion.Grad).Where(s => s.stadion.Grad.DrzavaID == search.DrzavaID);
                }
                if (search?.LigaID.HasValue == true)
                {
                    q = q.Where(s => s.LigaID == search.LigaID);
                }
                if (search?.StadionID.HasValue == true)
                {
                    q = q.Where(s => s.StadionID == search.StadionID);
                }
            }
            var list = q.ToList();
            return _mapper.Map<List<Utakmica>>(list);

        }
    }
}
