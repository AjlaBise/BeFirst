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
    public class OpremaController : ControllerBase
    {

        private readonly IOpremaServices _oprema;

        public OpremaController(IOpremaServices oprema)
        {
            _oprema = oprema;
        }


        [HttpGet]
        public List<Models.Oprema> Get([FromQuery] OpremaPretragaRequest request)
        {
            return _oprema.Get(request);
        }

        [HttpGet("{id}")]
        public Models.Oprema GetById(int id)
        {
            return _oprema.GetById(id);
        }


        [HttpPost]

        public Models.Oprema Insert(Models.Oprema oprema)
        {
            return _oprema.Insert(oprema);
        }

        [HttpPut("{id}")]
        public Models.Oprema Update(int id, Models.Oprema oprema)
        {
            return _oprema.Update(id, oprema);
        }

        [HttpDelete("{id}")]

        public bool Delete(int id)
        {
            return _oprema.Delete(id);
        }
    }
}
