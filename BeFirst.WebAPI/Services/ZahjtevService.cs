using AutoMapper;
using BeFirst.WebAPI.Database;
using BeFirst.WebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services
{
    public class ZahjtevService : IZahjtevService
    {
        private readonly BeFirstContext _zahtjev;
        private readonly IMapper _mapper;

        public ZahjtevService(BeFirstContext zahtjev, IMapper mapper)
        {
            _zahtjev = zahtjev;
            _mapper = mapper;
        }

        public List<Models.Zahtjev> Get(int id)
        {
            var list = _zahtjev.Zahtjev.Where(x => x.KorisnikId == id).ToList();

            return _mapper.Map<List<Models.Zahtjev>>(list);
        }

        public List<Models.Zahtjev> GetAll()
        {
            var list = _zahtjev.Zahtjev.ToList();
            return _mapper.Map<List<Models.Zahtjev>>(list);
        }

        public Models.Zahtjev GetById(int id)
        {
            var zahtjev = _zahtjev.Zahtjev.Where(k => k.Id == id).Single();

            return _mapper.Map<Models.Zahtjev>(zahtjev);
        }

        public Models.Zahtjev Insert(Models.Zahtjev zahtjev)
        {
            var ZahtjevEntity = _mapper.Map<Database.Zahtjev>(zahtjev);

            _zahtjev.Zahtjev.Add(ZahtjevEntity);
            _zahtjev.SaveChanges();

            return _mapper.Map<Models.Zahtjev>(ZahtjevEntity);
        }

        public Models.Zahtjev Update(int id, Models.Zahtjev zahtjev)
        {
            var ZahtjevEntity = _zahtjev.Zahtjev.Find(id);

            _zahtjev.Zahtjev.Attach(ZahtjevEntity);
            _zahtjev.Zahtjev.Update(ZahtjevEntity);

            _mapper.Map(zahtjev, ZahtjevEntity);

            _zahtjev.SaveChanges();

            return _mapper.Map<Models.Zahtjev>(ZahtjevEntity);
        }
    }
}
