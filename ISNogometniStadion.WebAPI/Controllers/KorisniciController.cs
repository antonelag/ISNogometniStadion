using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ISNogometniStadion.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : BaseCRUDController<Korisnik, KorisniciSearchRequest, KorisniciInsertRequest, KorisniciInsertRequest>
    {
        public KorisniciController(ICRUDService<Korisnik, KorisniciSearchRequest, KorisniciInsertRequest, KorisniciInsertRequest> service) : base(service)
        {
        }
    }
}