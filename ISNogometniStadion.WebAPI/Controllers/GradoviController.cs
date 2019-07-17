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
    public class GradoviController : ControllerBase
    {
        private IGradoviService _gradoviService;
        public GradoviController(IGradoviService gradoviService)
        {
            _gradoviService = gradoviService;
        }
        [HttpGet]
        public ActionResult<List<Grad>> Get()
        {
            return _gradoviService.Get();
        }
        [HttpGet("{id}")]
        public Grad GetById(int id)
        {
            return _gradoviService.GetById(id);
        }
        [HttpPost]
        public Grad Insert(GradoviInsertRequest req)
        {
            return _gradoviService.Insert(req);
        }
        [HttpPut("{id}")]
        public Grad Update(int id, GradoviUpdateRequest req)
        {
            return _gradoviService.Update(id, req);
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _gradoviService.Delete(id);
        }
    }
}