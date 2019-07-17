using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ISNogometniStadion.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _korisniciService;
        private readonly IMapper _mapper;
        public KorisniciController(IKorisniciService service, IMapper mapper)
        {
            _korisniciService = service;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<List<Korisnik>> Get()
        {
            return _korisniciService.Get();
        }
        [HttpGet("{id}")]
        public Korisnik GetById(int id)
        {
            return _korisniciService.GetById(id);
        }
        [HttpPost]
        public Korisnik Insert(KorisniciInsertRequest req)
        {
            return _korisniciService.Insert(req);
        }
        [HttpPut("{id}")]
        public Korisnik Update(int id ,KorisniciUpdateRequest req)
        {
            return _korisniciService.Update(id, req);
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _korisniciService.Delete(id);
        }
      
    }
}