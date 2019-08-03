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
    public class SjedalaController : BaseCRUDController<Sjedalo, SjedalaSearchRequest, SjedalaInsertRequest, SjedalaInsertRequest>
    {
        public SjedalaController(ICRUDService<Sjedalo, SjedalaSearchRequest, SjedalaInsertRequest, SjedalaInsertRequest> service) : base(service)
        {
        }
    }
}