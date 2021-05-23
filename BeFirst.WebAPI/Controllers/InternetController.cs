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
    public class InternetController : ControllerBase
    {
        private readonly IInternetService _internet;

        public InternetController(IInternetService internet)
        {
            _internet = internet;
        }

        [HttpGet]
        public List<Models.Internet> Get([FromQuery] InternetPretragaRequest request)
        {
            return _internet.Get(request);
        }

        [HttpGet("{id}")]
        public Models.Internet GetById(int id)
        {
            return _internet.GetById(id);
        }

        [HttpPost]
        public Models.Internet Insert(Models.Internet internet)
        {
            return _internet.Insert(internet);
        }


        [HttpPut("{id}")]
        public Models.Internet Update(int id, Models.Internet internet)
        {
            return _internet.Update(id, internet);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _internet.Delete(id);
        }
    }
}
