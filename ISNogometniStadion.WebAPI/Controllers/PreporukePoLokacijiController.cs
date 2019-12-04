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
    public class PreporukePoLokacijiController : BaseCRUDController<Model.PreporukaPoLokaciji, PreporukaSearchRequest, PreporukePoLokacijiInsertRequest, PreporukePoLokacijiInsertRequest>
    {
        public PreporukePoLokacijiController(ICRUDService<PreporukaPoLokaciji, PreporukaSearchRequest, PreporukePoLokacijiInsertRequest, PreporukePoLokacijiInsertRequest> service) : base(service)
        {
        }
    }
}