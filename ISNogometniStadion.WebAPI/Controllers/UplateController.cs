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
    public class UplateController : BaseCRUDController<Uplata, UplateSearchRequest, UplateInsertRequest, UplateInsertRequest>
    {
        public UplateController(ICRUDService<Uplata, UplateSearchRequest, UplateInsertRequest, UplateInsertRequest> service) : base(service)
        {
        }
    }
}