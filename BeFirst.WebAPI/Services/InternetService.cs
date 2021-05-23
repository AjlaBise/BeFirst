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
    public class InternetService : IInternetService
    {
        private readonly BeFirstContext _context;
        private readonly IMapper _mapper;

        public InternetService(BeFirstContext internet, IMapper mapper)
        {
            _context = internet;
            _mapper = mapper;
        }

        public bool Delete(int id)
        {
            var paketi = _context.Paket.Where(x => x.InternetId == id).ToList();
            paketi.ForEach(x => x.InternetId = null);
            _context.SaveChanges();

            var entity = _context.Internet.Find(id);
            if (entity != null)
            {
                _context.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Models.Internet> Get(InternetPretragaRequest request)
        {
            var query = _context.Internet.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.Contains(request.Naziv));
            }

            var list = query.ToList();

            return _mapper.Map<List<Models.Internet>>(list);
        }

        public Models.Internet GetById(int id)
        {
            var internet = _context.Internet.Where(k => k.Id == id).Single();

            return _mapper.Map<Models.Internet>(internet);
        }

        public Models.Internet Insert(Models.Internet internet)
        {
            var InternetEntity = _mapper.Map<Database.Internet>(internet);

            _context.Internet.Add(InternetEntity);
            _context.SaveChanges();

            return _mapper.Map<Models.Internet>(InternetEntity);
        }

        public Models.Internet Update(int id, Models.Internet internet)
        {
            var internetEntity = _context.Internet.Find(id);

            _context.Internet.Attach(internetEntity);
            _context.Internet.Update(internetEntity);

            _mapper.Map(internet, internetEntity);

            _context.SaveChanges();

            return _mapper.Map<Models.Internet>(internetEntity);
        }
    }
}
