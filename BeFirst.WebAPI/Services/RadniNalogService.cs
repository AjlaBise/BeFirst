using AutoMapper;
using BeFirst.WebAPI.Database;
using BeFirst.WebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services
{
    public class RadniNalogService : IRadniNalogService
    {
        private readonly BeFirstContext _radniNalog;
        private readonly IMapper _mapper;

        public RadniNalogService(BeFirstContext radniNalog, IMapper mapper)
        {
            _radniNalog = radniNalog;
            _mapper = mapper;
        }

        public List<Models.RadniNalog> Get()
        {
            var list = _radniNalog.RadniNalog.ToList();

            return _mapper.Map<List<Models.RadniNalog>>(list);
        }


        public Models.RadniNalog Insert(Models.RadniNalog radniNalog)
        {
            var entity = _mapper.Map<Database.RadniNalog>(radniNalog);

            _radniNalog.RadniNalog.Add(entity);
            _radniNalog.SaveChanges();

            return _mapper.Map<Models.RadniNalog>(entity);

        }

        public Models.RadniNalog Update(int id, Models.RadniNalog radniNalog)
        {
            var radniNalogEntity = _radniNalog.RadniNalog.Find(id);

            _radniNalog.RadniNalog.Attach(radniNalogEntity);
            _radniNalog.RadniNalog.Update(radniNalogEntity);

            _mapper.Map(radniNalog, radniNalogEntity);

            _radniNalog.SaveChanges();

            return _mapper.Map<Models.RadniNalog>(radniNalogEntity);
        }
    }
}
