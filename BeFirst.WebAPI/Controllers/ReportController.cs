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
    public class ReportController : ControllerBase
    {
        private readonly IReportService _context;

        public ReportController(IReportService context)
        {
            _context = context;
        }

        [HttpGet]
        public int Get([FromQuery] ReportSearchRequest request)
        {
            if (request.Year == null)
                request.Year = DateTime.Now.Year;

            return _context.GetRadniNalogCount(request);
        }

        [HttpGet("GetRadniNalogSum")]
        public int GetSum([FromQuery] ReportSearchRequest request)
        {
            if (request.Year == null)
                request.Year = DateTime.Now.Year;

            return _context.GetRadniNalogSum(request);
        }


        [HttpGet("GetBrojOprema")]
        public int GetList([FromQuery] ReportSearchRequest request)
        {
            if (request.Year == null)
                request.Year = DateTime.Now.Year;

            return _context.GetBrojOprema(request);

        }
    }
}
