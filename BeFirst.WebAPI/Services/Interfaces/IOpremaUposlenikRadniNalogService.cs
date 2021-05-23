using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services.Interfaces
{
    public interface IOpremaUposlenikRadniNalogService
    {
        List<Models.OpremaUposlenikRadniNalog> Get();

        Models.OpremaUposlenikRadniNalog Insert(Models.OpremaUposlenikRadniNalog opremaUposlenikRadniNalog);

        Models.OpremaUposlenikRadniNalog Update(int id, Models.OpremaUposlenikRadniNalog opremaUposlenikRadniNalog);
    }
}
