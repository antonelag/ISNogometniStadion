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
    public class KorisniciInsertController : ControllerBase
    {
        private readonly IKorisniciService _service;

        public KorisniciInsertController(IKorisniciService service)
        {
            _service = service;
        }
       [HttpPost]
        public Model.Korisnik Insert(KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpGet]
        public List<Model.Korisnik> Get([FromQuery]KorisniciSearchRequest request)
        {
            return _service.Get(request);
        }
    }
}