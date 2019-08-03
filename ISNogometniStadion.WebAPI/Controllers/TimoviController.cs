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
  
    public class TimoviController : BaseCRUDController<Tim, TimoviSearchRequest, TimoviInsertRequest, TimoviInsertRequest>
    {
        public TimoviController(ICRUDService<Tim, TimoviSearchRequest, TimoviInsertRequest, TimoviInsertRequest> service) : base(service)
        {
        }
    }
}