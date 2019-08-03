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
    public class UlaznicaController : BaseCRUDController<Ulaznica, UlazniceSearchRequest, UlazniceInsertRequest, UlazniceInsertRequest>
    {
        public UlaznicaController(ICRUDService<Ulaznica, UlazniceSearchRequest, UlazniceInsertRequest, UlazniceInsertRequest> service) : base(service)
        {
        }
    }
}