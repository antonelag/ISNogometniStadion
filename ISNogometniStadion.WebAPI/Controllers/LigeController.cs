using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WebAPI.Database;
using ISNogometniStadion.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ISNogometniStadion.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LigeController : BaseCRUDController<Liga, LigaSearchRequest, LigaInsertRequest, LigaInsertRequest>
    {
        public LigeController(ICRUDService<Liga, LigaSearchRequest, LigaInsertRequest, LigaInsertRequest> service) : base(service)
        {
        }
    }
}