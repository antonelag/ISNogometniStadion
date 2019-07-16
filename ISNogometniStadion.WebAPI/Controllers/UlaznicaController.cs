using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISNogometniStadion.Model;
using ISNogometniStadion.WebAPI.Database;
using ISNogometniStadion.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ISNogometniStadion.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UlaznicaController : ControllerBase
    {
        private readonly IUlaznicaService _ulaznicaService;
        public UlaznicaController(IUlaznicaService ulaznicaService)
        {
            _ulaznicaService = ulaznicaService;
        }
        [HttpGet]
        public ActionResult <IEnumerable<Ulaznice>> Get()
        {
            return Ok(_ulaznicaService.Get());
        }


        [HttpGet("{id}")]
        public ActionResult<Ulaznice> GetById(int id)
        {
            return Ok(_ulaznicaService.GetById(id));
        }

        [HttpPost]
        public Ulaznice Insert(Ulaznice ulaznica)
        {
            return new Ulaznice()
            {

                UlaznicaID = -1,
                KorisnikID = ulaznica.KorisnikID,
                SjedaloID = ulaznica.SjedaloID,
                UtakmicaID = ulaznica.UtakmicaID
            };
        }
        [HttpPut("{id}")]
        public Ulaznice Update(int id, Ulaznice ulaznica)
        {
            return new Ulaznice()
            {

                UlaznicaID = -1,
                KorisnikID = ulaznica.KorisnikID,
                SjedaloID = ulaznica.SjedaloID,
                UtakmicaID = ulaznica.UtakmicaID
            };
        }
    }
}