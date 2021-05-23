using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services.Interfaces
{
    public interface IZahjtevService
    {
        Models.Zahtjev GetById(int id);

        List<Models.Zahtjev> Get(int id);

        Models.Zahtjev Insert(Models.Zahtjev zahtjev);

        Models.Zahtjev Update(int id, Models.Zahtjev zahtjev);
        List<Models.Zahtjev> GetAll();
    }
}
