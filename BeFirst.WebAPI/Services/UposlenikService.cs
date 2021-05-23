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
    public class UposlenikService : IUposlenikService
    {
        private readonly BeFirstContext _uposlenik;
        private readonly IMapper _mapper;

        public UposlenikService(BeFirstContext uposlenik, IMapper mapper)
        {
            _uposlenik = uposlenik;
            _mapper = mapper;
        }


        public List<Models.Uposlenik> Get(UposlenikPretragaRequest request)
        {
            var query = _uposlenik.Uposlenik.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Search))
            {
                query = query.Where(x => x.Ime.Contains(request.Search)
                || x.Prezime.Contains(request.Search)
                || x.Grad.Contains(request.Search)
                || x.Adresa.Contains(request.Search));
            }

            var list = query.ToList();

            return _mapper.Map<List<Models.Uposlenik>>(list);
        }


        public Models.Uposlenik Insert(Models.Uposlenik uposlenik)
        {
            var account = AccountService.CreateAccountForEmployee(uposlenik);
            var entity = _mapper.Map<Database.Uposlenik>(uposlenik);

            var accountEntity = _mapper.Map<Database.Account>(account);

            entity.Account = accountEntity;
            entity.Account.PasswordHash = "aaaaa";
            entity.Account.PasswordSalt = "aaaaa";
            entity.Account.UlogaId = 3;


            _uposlenik.Add(entity);
            _uposlenik.SaveChanges();

            return _mapper.Map<Models.Uposlenik>(uposlenik);
        }

        public Models.Uposlenik Update(int id, Models.Uposlenik uposlenik)
        {
            var entity = _uposlenik.Uposlenik.Find(id);

            _uposlenik.Uposlenik.Attach(entity);
            _uposlenik.Uposlenik.Update(entity);

            _mapper.Map(uposlenik, entity);

            _uposlenik.SaveChanges();

            return _mapper.Map<Models.Uposlenik>(entity);
        }

        public bool Delete(int id)
        {
            var entity = _uposlenik.Uposlenik.Find(id);
            if (entity != null)
            {
                _uposlenik.Remove(entity);
                _uposlenik.SaveChanges();
                return true;
            }
            return false;
        }

        public Models.Uposlenik GetById(int id)
        {
            var uposlenik = _uposlenik.Uposlenik.Where(k => k.Id == id).Single();

            return _mapper.Map<Models.Uposlenik>(uposlenik);
        }
    }
}
