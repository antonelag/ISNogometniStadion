using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
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
        public List<Ulaznica> Get([FromQuery]UlazniceSearchRequest req)
        {
            return _ulaznicaService.Get( req);
        }


        [HttpGet("{id}")]
        public Ulaznica GetById(int id)
        {
            return _ulaznicaService.GetById(id);
        }

        [HttpPost]
        public Ulaznica Insert(UlazniceInsertRequest req)
        {
            return _ulaznicaService.Insert(req);
        }
        [HttpPut("{id}")]
        public Ulaznica Update(int id, UlazniceInsertRequest req)
        {
            return _ulaznicaService.Update(id, req);
        }
        [HttpDelete]
        public string Delete(int id)
        {
            return _ulaznicaService.Delete(id);
        }
    }
}