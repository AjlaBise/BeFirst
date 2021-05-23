using BeFirst.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services.Interfaces
{
    public interface IPonudaService
    {
        Models.Ponuda GetById(int id);

        List<Models.Ponuda> Get(PonudaPretragaRequest request);

        Models.Ponuda Insert(Models.Ponuda ponuda);

        Models.Ponuda Update(int id, Models.Ponuda ponuda);

        bool Delete(int id);
    }
}
