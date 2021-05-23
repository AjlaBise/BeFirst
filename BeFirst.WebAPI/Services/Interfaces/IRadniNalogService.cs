using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services.Interfaces
{
    public interface IRadniNalogService
    {
        List<Models.RadniNalog> Get();

        Models.RadniNalog Insert(Models.RadniNalog radniNalog);

        Models.RadniNalog Update(int id, Models.RadniNalog radniNalog);
    }
}
