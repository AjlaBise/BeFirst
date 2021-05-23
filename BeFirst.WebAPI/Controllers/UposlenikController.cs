using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeFirst.Models.Requests;
using BeFirst.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeFirst.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UposlenikController : ControllerBase
    {
        private readonly IUposlenikService _uposlenik;

        public UposlenikController(IUposlenikService uposlenik)
        {
            _uposlenik = uposlenik;
        }

        [HttpGet]
        public List<Models.Uposlenik> Get([FromQuery] UposlenikPretragaRequest request)
        {
            return _uposlenik.Get(request);
        }

        [HttpGet("{id}")]
        public Models.Uposlenik GetById(int id)
        {
            return _uposlenik.GetById(id);
        }

        [HttpPost]
        public Models.Uposlenik Insert(Models.Uposlenik uposlenik)
        {
            return _uposlenik.Insert(uposlenik);
        }

        [HttpPut ("{id}")]
        public Models.Uposlenik Update(int id, Models.Uposlenik uposlenik)
        {
            return _uposlenik.Update(id, uposlenik);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _uposlenik.Delete(id);
        }
    }
}
