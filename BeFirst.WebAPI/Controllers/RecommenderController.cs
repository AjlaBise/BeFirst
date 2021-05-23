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
    public class RecommenderController : ControllerBase
    {
        private readonly IRecommenderService _service;
        public RecommenderController(IRecommenderService service)
        {
            _service = service;
        }

        [HttpGet]
        public Models.RecommenderModel Get([FromQuery] int id)
        {
            return _service.Get(id);
        }
    }
}
