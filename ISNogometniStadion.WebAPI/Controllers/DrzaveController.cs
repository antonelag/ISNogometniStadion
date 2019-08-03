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
 
    public class DrzaveController : BaseCRUDController<Drzava, DrzaveSearchRequest, DrzaveInsertRequest, DrzaveInsertRequest>
    { // da nema search ide object
        public DrzaveController(ICRUDService<Drzava, DrzaveSearchRequest, DrzaveInsertRequest, DrzaveInsertRequest> service) : base(service)
        {

        }
    }
}