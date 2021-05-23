using AutoMapper;
using BeFirst.WebAPI.Database;
using BeFirst.WebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services
{

    public class OpremaUposlenikRadniNalogService : IOpremaUposlenikRadniNalogService
    {
        private readonly BeFirstContext _OpremaUposlenikRadniNalog;
        private readonly IMapper _mapper;

        public OpremaUposlenikRadniNalogService(BeFirstContext opremaUposlenikRadniNalog, IMapper mapper)
        {
            _OpremaUposlenikRadniNalog = opremaUposlenikRadniNalog;
            _mapper = mapper;
        }


        public List<Models.OpremaUposlenikRadniNalog> Get()
        {
            var list = _OpremaUposlenikRadniNalog.OpremaUposlenikRadnoNalog.ToList();

            return _mapper.Map<List<Models.OpremaUposlenikRadniNalog>>(list);
        }


        public Models.OpremaUposlenikRadniNalog Insert(Models.OpremaUposlenikRadniNalog opremaUposlenikRadniNalog)
        {
            var entity = _mapper.Map<Database.OpremaUposlenikRadnoNalog>(opremaUposlenikRadniNalog);

            _OpremaUposlenikRadniNalog.OpremaUposlenikRadnoNalog.Add(entity);
            _OpremaUposlenikRadniNalog.SaveChanges();

            return _mapper.Map<Models.OpremaUposlenikRadniNalog>(entity);

        }

        public Models.OpremaUposlenikRadniNalog Update(int id, Models.OpremaUposlenikRadniNalog opremaUposlenikRadniNalog)
        {
            var entity = _OpremaUposlenikRadniNalog.OpremaUposlenikRadnoNalog.Find(id);

            _OpremaUposlenikRadniNalog.OpremaUposlenikRadnoNalog.Attach(entity);
            _OpremaUposlenikRadniNalog.OpremaUposlenikRadnoNalog.Update(entity);

            _mapper.Map(opremaUposlenikRadniNalog, entity);

            _OpremaUposlenikRadniNalog.SaveChanges();

            return _mapper.Map<Models.OpremaUposlenikRadniNalog>(entity);
        }

    }
}
