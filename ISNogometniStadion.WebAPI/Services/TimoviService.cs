﻿using AutoMapper;
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
    public class TimoviService:ITimoviService
    {
        private readonly ISNogometniStadionContext _context;
        private readonly IMapper _mapper;
        public TimoviService(ISNogometniStadionContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public string Delete(int id)
        {
            var t = _context.Timovi.FirstOrDefault(r => r.TimID == id);
            if (t != null)
            {
                _context.Timovi.Remove(t);
                _context.SaveChanges();
                return "Uspjesno obrisano!";
            }
            else
                throw new UserException("Tim ne postoji!");
        }

        public List<Tim> Get(TimoviSearchRequest req)
        {
            var q = _context.Timovi.AsQueryable();
            if (!string.IsNullOrEmpty(req?.Naziv))
                q = q.Where(s => s.Naziv.StartsWith(req.Naziv));
            var list = q.ToList();
            return _mapper.Map<List<Tim>>(list);

        }

        public Tim GetById(int id)
        {
            var t = _context.Timovi.FirstOrDefault(r => r.TimID == id);
            if (t != null)
            {
                return _mapper.Map<Tim>(t);
            }
            else
                throw new UserException("Tim ne postoji");
        }

        public Tim Insert(TimoviInsertRequest req)
        {
            var a = _context.Timovi.FirstOrDefault(s => s.Naziv == req.Naziv);
            var g = _context.Stadioni.FirstOrDefault(s => s.StadionID == req.StadionID);
            if (a == null && g != null)
            {
                var t = _mapper.Map<Database.Timovi>(req);
                _context.Add(t);
                _context.SaveChanges();
                return _mapper.Map<Tim>(t);
            }
            else
                throw new UserException("Pogresan unos!");
            }

        public Tim Update(int id, TimoviInsertRequest req)
        {
            var t = _context.Timovi.FirstOrDefault(s => s.TimID == id);
            var g = _context.Stadioni.FirstOrDefault(r => r.StadionID == req.StadionID);
            var a = _context.Timovi.FirstOrDefault(e => e.Naziv == req.Naziv && e.TimID!=id);
            if (t != null && g != null && a==null)
            {
                _mapper.Map<TimoviInsertRequest, Database.Timovi>(req, t);
                _context.SaveChanges();
                return _mapper.Map<Tim>(t);
            }
            else
                throw new UserException("Pogresan unos");
        }
    }
}
