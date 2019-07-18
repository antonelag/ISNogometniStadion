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
    public class UtakmiceController : ControllerBase
    {
        private readonly IUtakmiceService _utakmiceService;
        public UtakmiceController(IUtakmiceService utakmiceService)
        {
            _utakmiceService = utakmiceService;
        }
        [HttpGet]
        public List<Utakmica> Get()
        {
            return _utakmiceService.Get();
        }
        [HttpGet("{id}")]
        public Utakmica GetById(int id)
        {
            return _utakmiceService.GetById(id);
        }
        [HttpPost]
        public Utakmica Insert(UtakmiceInsertRequest req)
        {
            return _utakmiceService.Insert(req);
        }
        [HttpPut]
        public Utakmica Update(int id, UtakmiceUpdateRequest req)
        {
            return _utakmiceService.Update(id, req);
        }
        [HttpDelete]
        public string Delete(int id)
        {
            return _utakmiceService.Delete(id);
        }
    }
}