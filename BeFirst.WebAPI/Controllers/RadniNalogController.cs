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
    public class RadniNalogController : ControllerBase
    {
        private readonly IRadniNalogService _radniNalog;

        public RadniNalogController(IRadniNalogService radniNalog)
        {
            _radniNalog = radniNalog;
        }

        [HttpGet]
        public List<Models.RadniNalog> Get()
        {
            return _radniNalog.Get();
        }

        [HttpPost]
        public Models.RadniNalog Insert(Models.RadniNalog radniNalog)
        {
            return _radniNalog.Insert(radniNalog);
        }


        [HttpPut("{id}")]
        public Models.RadniNalog Update(int id, Models.RadniNalog radniNalog)
        {
            return _radniNalog.Update(id, radniNalog);
        }


    }
}
