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
    public class PozicijaController : ControllerBase
    {
        private readonly IPozicijeService _pozicija;

        public PozicijaController(IPozicijeService pozicija)
        {
            _pozicija = pozicija;
        }

        [HttpGet]
        public List<Models.Pozicija> Get()
        {
            return _pozicija.Get();
        }

    }
}
