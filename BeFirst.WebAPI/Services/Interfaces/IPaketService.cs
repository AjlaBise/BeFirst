using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services.Interfaces
{
   public interface IPaketService
    {
        Models.Paket GetById(int id);

        List<Models.Paket> Get();

        Models.Paket Insert(Models.Paket paket);

        Models.Paket Update(int id, Models.Paket paket);

        bool Delete(int id);
    }
}
