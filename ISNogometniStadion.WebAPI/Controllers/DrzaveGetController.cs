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
    public class DrzaveGetController : ControllerBase
    {
        private readonly DrzaveService _service;

        public DrzaveGetController(DrzaveService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Drzava>> Get([FromQuery]DrzaveSearchRequest req)
        {
            return _service.Get(req);
        }
        [HttpPost]
        public Model.Drzava Insert(DrzaveInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}