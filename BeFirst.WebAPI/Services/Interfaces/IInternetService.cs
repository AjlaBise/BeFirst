using BeFirst.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services.Interfaces
{
    public interface IInternetService
    {
        Models.Internet GetById(int id);

        List<Models.Internet> Get(InternetPretragaRequest request);

        Models.Internet Insert(Models.Internet internet);

        Models.Internet Update(int id, Models.Internet internet);

        bool Delete(int id);


    }
}
