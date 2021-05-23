using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeFirst.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeFirst.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PaketController : ControllerBase
    {

        private readonly IPaketService _paket;

        public PaketController(IPaketService paket)
        {
            _paket = paket;
        }

        [HttpGet]
        public List<Models.Paket> Get()
        {
            return _paket.Get();
        }
        [HttpGet("{id}")]
        public Models.Paket GetById(int id)
        {
            return _paket.GetById(id);
        }

        [HttpPost]
        public Models.Paket Insert(Models.Paket paket)
        {
            return _paket.Insert(paket);
        }


        [HttpPut("{id}")]
        public Models.Paket Update(int id, Models.Paket paket)
        {
            return _paket.Update(id, paket);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _paket.Delete(id);
        }
    }
}
