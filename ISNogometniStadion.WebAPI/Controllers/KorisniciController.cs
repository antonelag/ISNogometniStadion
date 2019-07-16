using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public KorisniciController(IKorisniciService service)
        {
            _korisniciService = service;
        }
        [HttpGet]
        public ActionResult<List<Korisnik>> Get()
        {
            return _korisniciService.Get();
        }
        [HttpPost]
        public Korisnik Insert(KorisniciInsertRequest req)
        {
            return _korisniciService.Insert(req);
        }
    }
}