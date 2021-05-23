using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeFirst.WebAPI.Services;
using BeFirst.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeFirst.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ZahtjevController : ControllerBase
    {
        private readonly IZahjtevService _service;

        public ZahtjevController(IZahjtevService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Models.Zahtjev> GetZahtjeve()
        {
            return _service.GetAll();
        }

        [HttpGet("/api/GetZahtjeve/{korisnikId}")]
        public List<Models.Zahtjev> GetZahtjeve(int korisnikId)
        {
            return _service.Get(korisnikId);
        }

        [HttpPost]
        public Models.Zahtjev Insert(Models.Zahtjev zahtjev)
        {
            return _service.Insert(zahtjev);
        }

        [HttpGet("{id}")]
        public Models.Zahtjev GetById(int id)
        {
            return _service.GetById(id);
        }


        [HttpPut("{id}")]
        public Models.Zahtjev Update(int id, Models.Zahtjev zahtjev)
        {
            return _service.Update(id, zahtjev);
        }
    }
}
