using BeFirst.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services.Interfaces
{
    public interface IAccountService
    {
        Task<Models.Account> Authenticate(AuthenticateRequest request);

        List<Models.Account> Get();
    }
}
