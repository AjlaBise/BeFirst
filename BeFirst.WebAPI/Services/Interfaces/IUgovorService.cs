using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services.Interfaces
{
    public interface IUgovorService
    {
        List<Models.Ugovor> Get();

        Models.Ugovor Insert(Models.Ugovor ugovor);
    }
}

