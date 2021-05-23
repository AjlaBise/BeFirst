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
    public class VrstaPaketa : ControllerBase
    {
        private readonly IVrstaPaketaServiices _context;

        public VrstaPaketa(IVrstaPaketaServiices context)
        {
            _context = context;
        }


        [HttpGet]
        public List<Models.VrstaPaketa> Get()
        {
            return _context.Get();
        }
    }
}
