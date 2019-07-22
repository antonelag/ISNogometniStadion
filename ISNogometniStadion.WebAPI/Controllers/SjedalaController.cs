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
    public class SjedalaController : ControllerBase
    {
        private readonly ISjedalaService _sjedalaService;
        public SjedalaController(ISjedalaService sjedalaService)
        {
            _sjedalaService = sjedalaService;
        }
        [HttpGet]
        public List<Sjedalo> Get([FromQuery]SjedalaSearchRequest req)
        {
            return _sjedalaService.Get(req);
        }
        [HttpGet("{id}")]
        public Sjedalo GetById(int id)
        {
            return _sjedalaService.GetById(id);
        }
        [HttpPost]
        public Sjedalo Insert(SjedalaInsertRequest req)
        {
            return _sjedalaService.Insert(req);
        }
        [HttpPut("{id}")]
        public Sjedalo Update(int id, SjedalaInsertRequest req)
        {
            return _sjedalaService.Update(id, req);
        }
        [HttpDelete]
        public string Delete(int id)
        {
            return _sjedalaService.Delete(id);
        }
    }
}