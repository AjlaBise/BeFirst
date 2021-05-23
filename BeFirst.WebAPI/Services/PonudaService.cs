using AutoMapper;
using BeFirst.Models;
using BeFirst.Models.Requests;
using BeFirst.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services.Interfaces
{
    public class PonudaService : IPonudaService
    {
        private readonly BeFirstContext _ponuda;
        private readonly IMapper _mapper;
        public PonudaService (BeFirstContext ponuda, IMapper mapper)
        {
            _ponuda = ponuda;
            _mapper = mapper;
           
        }

    

        public List<Models.Ponuda> Get(PonudaPretragaRequest request)
        {
            var query = _ponuda.Ponuda.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Search))
            {
                query = query.Where(x => x.Naziv.Contains(request.Search));
            }



            var list = query.ToList();

            return _mapper.Map<List<Models.Ponuda>>(list);
        }

        public Models.Ponuda Insert(Models.Ponuda ponuda)
        {
            var entity = _mapper.Map<Database.Ponuda>(ponuda);

            _ponuda.Ponuda.Add(entity);
            _ponuda.SaveChanges();

            return _mapper.Map<Models.Ponuda>(entity);
                
        }

        public Models.Ponuda Update(int id, Models.Ponuda ponuda)
        {
            var PonudaEntity = _ponuda.Ponuda.Find(id);

            _ponuda.Ponuda.Attach(PonudaEntity);
            _ponuda.Ponuda.Update(PonudaEntity);

            _mapper.Map(ponuda, PonudaEntity);

            _ponuda.SaveChanges();

            return _mapper.Map<Models.Ponuda>(PonudaEntity);
        }

        public bool Delete(int id)
        {
            var entity = _ponuda.Ponuda.Find(id);
            if (entity != null)
            {
                _ponuda.Remove(entity);
                _ponuda.SaveChanges();
                return true;
            }
            return false;
        }

        public Models.Ponuda GetById(int id)
        {
            var ponuda = _ponuda.Ponuda.Where(k => k.Id == id).Single();

            return _mapper.Map<Models.Ponuda>(ponuda);
        }
    }
}
