using AutoMapper;
using BeFirst.Models;
using BeFirst.Models.Requests;
using BeFirst.WebAPI.Database;
using BeFirst.WebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services
{
    public class OpremaServices : IOpremaServices
    {
        private readonly BeFirstContext _oprema;
        private readonly IMapper _mapper;

        public OpremaServices(BeFirstContext oprema, IMapper mapper)
        {
            _oprema = oprema;
            _mapper = mapper;
        }

        public bool Delete(int id)
        {
            var entity = _oprema.Oprema.Find(id);
            if (entity != null)
            {
                _oprema.Remove(entity);
                _oprema.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Models.Oprema> Get(OpremaPretragaRequest request)
        {
            var query = _oprema.Oprema.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Search))
            {
                query = query.Where(x => x.Naziv.Contains(request.Search));
            }

            var list = query.ToList();

            return _mapper.Map<List<Models.Oprema>>(list);
        }

        public Models.Oprema GetById(int id)
        {
            var oprema = _oprema.Oprema.Where(k => k.Id == id).Single();

            return _mapper.Map<Models.Oprema>(oprema);
        }

        public Models.Oprema Insert(Models.Oprema oprema)
        {
            var OpremaEntity = _mapper.Map<Database.Oprema>(oprema);

            _oprema.Oprema.Add(OpremaEntity);
            _oprema.SaveChanges();

            return _mapper.Map<Models.Oprema>(OpremaEntity);
        }

        public Models.Oprema Update(int id, Models.Oprema oprema)
        {
            var OpremaEntity = _oprema.Oprema.Find(id);

            _oprema.Oprema.Attach(OpremaEntity);
            _oprema.Oprema.Update(OpremaEntity);

            _mapper.Map(oprema, OpremaEntity);

            _oprema.SaveChanges();

            return _mapper.Map<Models.Oprema>(OpremaEntity);
        }
    }
}
