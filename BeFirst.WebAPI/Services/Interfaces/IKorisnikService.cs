using BeFirst.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services.Interfaces
{
    public interface IKorisnikService
    {
        Models.Korisnik GetById(int id);

        List<Models.Korisnik> Get(KorisnikPretragaRequest request);

        Models.Korisnik Insert(Models.Korisnik korisnik);

        Models.Korisnik Update(int id, Models.Korisnik korisnik);

        bool Delete(int id);
    }
}
