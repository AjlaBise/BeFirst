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
    public class OpremaUposlenikRadniNalogController : ControllerBase
    {
        private readonly IOpremaUposlenikRadniNalogService _opremaUposlenikRadniNalog;
        public OpremaUposlenikRadniNalogController(IOpremaUposlenikRadniNalogService opremaUposlenikRadniNalog)
        {
            _opremaUposlenikRadniNalog = opremaUposlenikRadniNalog;
        }


        [HttpGet]
        public List<Models.OpremaUposlenikRadniNalog> Get()
        {
            return _opremaUposlenikRadniNalog.Get();
        }


        [HttpPost]
        public Models.OpremaUposlenikRadniNalog Insert(Models.OpremaUposlenikRadniNalog opremaUposlenikRadniNalogadniNalog)
        {
            return _opremaUposlenikRadniNalog.Insert(opremaUposlenikRadniNalogadniNalog);
        }


        [HttpPut("{id}")]
        public Models.OpremaUposlenikRadniNalog Update(int id, Models.OpremaUposlenikRadniNalog opremaUposlenikRadniNalogadniNalog)
        {
            return _opremaUposlenikRadniNalog.Update(id, opremaUposlenikRadniNalogadniNalog);
        }

    }
}
