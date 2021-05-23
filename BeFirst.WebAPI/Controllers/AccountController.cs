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
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _service;

        public AccountController(IAccountService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public List<Models.Account> Get()
        {
            return _service.Get();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<Models.Account> Authenticate(AuthenticateRequest request)
        {
            return await _service.Authenticate(request);
        }

    }
}
