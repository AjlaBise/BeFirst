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
    public class PonudaController : ControllerBase
    {
        private readonly IPonudaService _ponuda;

        public PonudaController(IPonudaService ponuda)
        {
            _ponuda = ponuda;
        }

        [HttpGet]
        public List<Models.Ponuda> Get([FromQuery] PonudaPretragaRequest request)
        {
            return _ponuda.Get(request);
        }

        [HttpGet("{id}")]
        public Models.Ponuda GetById(int id)
        {
            return _ponuda.GetById(id);
        }


        [HttpPost]

        public Models.Ponuda Insert (Models.Ponuda ponuda)
        {
            return _ponuda.Insert(ponuda);
        }

        [HttpPut("{id}")]
        public Models.Ponuda Update (int id, Models.Ponuda ponuda)
        {
            return _ponuda.Update(id, ponuda);
        }

        [HttpDelete("{id}")]

        public bool Delete(int id)
        {
            return _ponuda.Delete(id);
        }

    }
}
