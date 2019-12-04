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
    public class PreporukePoStadionuController : BaseCRUDController<Model.PreporukaPoStadionu, PreporukaSearchRequest, PreporukePoStadionuInsertRequest, PreporukePoStadionuInsertRequest>
    {
        public PreporukePoStadionuController(ICRUDService<PreporukaPoStadionu, PreporukaSearchRequest, PreporukePoStadionuInsertRequest, PreporukePoStadionuInsertRequest> service) : base(service)
        {
        }
    }
}