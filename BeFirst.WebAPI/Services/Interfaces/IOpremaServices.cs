using BeFirst.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services.Interfaces
{
     public interface IOpremaServices
    {
        List<Models.Oprema> Get(OpremaPretragaRequest request);

        Models.Oprema GetById(int id);

        Models.Oprema Insert(Models.Oprema oprema);

        Models.Oprema Update(int id, Models.Oprema oprema);

        bool Delete(int id);
    }
}
