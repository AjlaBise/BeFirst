using BeFirst.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services.Interfaces
{
    public interface IUposlenikService
    {
        Models.Uposlenik GetById(int id);

        List<Models.Uposlenik> Get(UposlenikPretragaRequest request);

        Models.Uposlenik Insert(Models.Uposlenik uposlenik);

        Models.Uposlenik Update(int id, Models.Uposlenik uposlenik);

        bool Delete(int id);
    }
}
