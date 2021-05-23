using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services.Interfaces
{
    public interface IPozicijeService
    {
        List<Models.Pozicija> Get();

    }
}
