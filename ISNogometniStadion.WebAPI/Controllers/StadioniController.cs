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
    public class StadioniController : ControllerBase
    {
        private readonly IStadioniService _stadioniService;
        public StadioniController(IStadioniService stadioniService)
        {
            _stadioniService = stadioniService;
        }
        [HttpGet]
        public List<Stadion> Get()
        {
            return _stadioniService.Get();
        }
        [HttpGet("{id}")]
        public Stadion GetById(int id)
        {
            return _stadioniService.GetById(id);
        }
        [HttpPost]
        public Stadion Insert(StadioniInsertRequest req)
        {
            return _stadioniService.Insert(req);
        }
        [HttpPut]
        public Stadion Update(int id, StadioniUpdateRequest req)
        {
            return _stadioniService.Update(id, req);
        }
        [HttpDelete]
        public string Delete(int id)
        {
            return _stadioniService.Delete(id);
        }
    }
}