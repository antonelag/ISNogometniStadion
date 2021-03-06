﻿using System;
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
    public class GradoviGetController : ControllerBase
    {
        private readonly GradService _service;

        public GradoviGetController(GradService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Grad>> Get([FromQuery]GradoviSearchRequest req)
        {
            return _service.Get(req);
        }
        [HttpPost]
        public Model.Grad Insert(GradoviInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}