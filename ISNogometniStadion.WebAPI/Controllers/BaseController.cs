using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISNogometniStadion.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ISNogometniStadion.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T,TSearch> : ControllerBase
    {
        private readonly IService<T,TSearch> _service;
        public BaseController(IService<T, TSearch> service)
        {
            _service =service;
        }
        [HttpGet]
        public ActionResult<List<T>> Get([FromQuery]TSearch req)
        {
            return _service.Get(req);
        }
        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _service.GetById(id);
        }
        //[HttpPost]
        //public T Insert(TInsert req)
        //{
        //    return _service.Insert(req);
        //}
        //[HttpPut("{id}")]
        //public T Update(int id, TInsert req)
        //{
        //    return _service.Update(id, req);
        //}
        //[HttpDelete("{id}")]
        //public string Delete(int id)
        //{
        //    return _service.Delete(id);
        //}
    }
}