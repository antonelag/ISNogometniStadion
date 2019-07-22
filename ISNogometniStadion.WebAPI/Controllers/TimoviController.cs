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
    public class TimoviController : ControllerBase
    {
        private readonly ITimoviService _timoviService;
            public TimoviController(ITimoviService timoviService)
        {
            _timoviService = timoviService;
        }
        [HttpGet]
        public ActionResult<List<Tim>> Get()
        {
            return _timoviService.Get();
        }
        [HttpGet("{id}")]
        public Tim GetById(int id)
        {
            return _timoviService.GetById(id);
        }
        [HttpPost]
        public Tim Insert(TimoviInsertRequest req)
        {
            return _timoviService.Insert(req);
        }
        [HttpPut("{id}")]
        public Tim Update(int id, TimoviInsertRequest req)
        {
            return _timoviService.Update(id, req);
        }
        [HttpDelete]
        public string Delete(int id)
        {
            return _timoviService.Delete(id);
        }
    }
}