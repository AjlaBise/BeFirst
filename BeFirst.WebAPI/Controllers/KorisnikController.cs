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
    public class KorisnikController : ControllerBase
    {
        private readonly IKorisnikService _korisnik;

        public KorisnikController(IKorisnikService korisnik)
        {
            _korisnik = korisnik;
        }

        [HttpGet]
        public List<Models.Korisnik> Get([FromQuery] KorisnikPretragaRequest request)
        {
            return _korisnik.Get(request);
        }

        [HttpGet("{id}")]
        public Models.Korisnik GetById(int id)
        {
            return _korisnik.GetById(id);
        }


        [HttpPost]
        public Models.Korisnik Insert (Models.Korisnik korisnik)
        {
            return _korisnik.Insert(korisnik);
        }

        [HttpPut("{id}")]
        public Models.Korisnik Update(int id, Models.Korisnik korisnik)
        {
            return _korisnik.Update(id, korisnik);
        }

        [HttpDelete("{id}")]
       public bool Delete (int id)
        {
            return _korisnik.Delete(id);
        }
    }
}
