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
    public class UgovorController : ControllerBase
    {
        private readonly IUgovorService _service;

        public UgovorController(IUgovorService service)
        {
            _service = service;
        }

        [HttpGet]

       public List<Models.Ugovor> Get ()
        {
            return _service.Get();
        }
        [HttpPost]
        public Models.Ugovor Insert (Models.Ugovor ugovor)
        {
            return _service.Insert(ugovor);
        }
    }
}
