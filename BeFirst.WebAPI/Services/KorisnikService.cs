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
    public class KorisnikService : IKorisnikService
    {
        private readonly BeFirstContext _korisnik;
        private readonly IMapper _mapper;

        public KorisnikService(BeFirstContext korisnik, IMapper mapper)
        {
            _korisnik = korisnik;
            _mapper = mapper;
        }


        public List<Models.Korisnik> Get(KorisnikPretragaRequest request)
        {
            var query = _korisnik.Korisnik.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Search))
            {
                query = query.Where(x => x.Ime.Contains(request.Search)
                || x.Prezime.Contains(request.Search)
                || x.Grad.Contains(request.Search)
                || x.Adresa.Contains(request.Search));
            }



            var list = query.ToList();

            return _mapper.Map<List<Models.Korisnik>>(list);
        }



        public Models.Korisnik Insert(Models.Korisnik korisnik)
        {
            var account = AccountService.CreateAccountForCustomer(korisnik);
            var korisnikEntity = _mapper.Map<Database.Korisnik>(korisnik);

            var accountEntity = _mapper.Map<Database.Account>(account);

            korisnikEntity.Account = accountEntity;
            korisnikEntity.Account.PasswordHash = "aaaaa";
            korisnikEntity.Account.PasswordSalt = "aaaaa";
            korisnikEntity.Account.UlogaId = 2;


            _korisnik.Account.Add(accountEntity);
            _korisnik.Korisnik.Add(korisnikEntity);
            _korisnik.SaveChanges();

            return _mapper.Map<Models.Korisnik>(korisnikEntity);
        }


        public Models.Korisnik Update(int id, Models.Korisnik korisnik)
        {
            var entity = _korisnik.Korisnik.Find(id);

            _korisnik.Korisnik.Attach(entity);
            _korisnik.Korisnik.Update(entity);

            _mapper.Map(korisnik, entity);

            _korisnik.SaveChanges();

            return _mapper.Map<Models.Korisnik>(entity);
        }

        public bool Delete(int id)
        {
            var entity = _korisnik.Korisnik.Find(id);
            if (entity != null)
            {
                _korisnik.Remove(entity);
                _korisnik.SaveChanges();
                return true;
            }
            return false;
        }

        public Models.Korisnik GetById(int id)
        {
            var korisnik = _korisnik.Korisnik.Where(k => k.Id == id).Single();

            return _mapper.Map<Models.Korisnik>(korisnik);
        }
    }
}
