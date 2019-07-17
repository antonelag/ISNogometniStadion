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
    public class DrzaveController : ControllerBase
    {
        private IDrzaveService _drzaveService;
        public DrzaveController(IDrzaveService drzaveService)
        {
            _drzaveService = drzaveService;
        }
        [HttpGet]
        public ActionResult<List<Drzava>> Get()
        {
            return _drzaveService.Get();
        }
        [HttpGet("{id}")]
        public Drzava GetById(int id)
        {
            return _drzaveService.GetById(id);
        }
        [HttpPost]
        public Drzava Insert(GradoviUpdateRequest req)
        {
            return _drzaveService.Insert(req);
        }
        [HttpPut("{id}")]
        public Drzava Update(int id, DrzaveUpdateRequest req)
        {
            return _drzaveService.Update(id, req);
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _drzaveService.Delete(id);
        }
    }
}