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
    public class TribineController : ControllerBase
    {
        private readonly ITribineService _tribineService;
        public TribineController(ITribineService tribineService)
        {
            _tribineService = tribineService;
        }
        [HttpGet]
        public List<Tribina> Get()
        {
            return _tribineService.Get();
        }
        [HttpGet("{id}")]
        public Tribina GetById(int id)
        {
            return _tribineService.GetById(id);
        }
        [HttpPost]
        public Tribina Insert(TribineInsertRequest req)
        {
            return _tribineService.Insert(req);
        }
        [HttpPut]
        public Tribina Update(int id, TribineUpdateRequest req)
        {
            return _tribineService.Update(id,req);
        }
        [HttpDelete]
        public string Delete(int id)
        {
            return _tribineService.Delete(id);
        }
    }
}