using AutoMapper;
using BeFirst.Models;
using BeFirst.Models.Requests;
using BeFirst.WebAPI.Database;
using BeFirst.WebAPI.Helpers;
using BeFirst.WebAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services
{
    public class AccountService : IAccountService
    {
        private readonly BeFirstContext _context;
        private readonly IMapper _mapper;
        public AccountService(BeFirstContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public static Models.Account CreateAccountForCustomer(Models.Korisnik korisnik)
        {
            Models.Account account = new Models.Account
            {
                KorisničkoIme = korisnik.Ime.ToLower() + '.' + korisnik.Prezime.ToLower(),
                Password="NEKA",
                UlogaId = 2
              
            };

            return account;
        }

        public static Models.Account CreateAccountForEmployee(Models.Uposlenik uposlenik)
        {
            Models.Account account = new Models.Account
            {
                KorisničkoIme = uposlenik.Ime.ToLower() + '.' + uposlenik.Prezime.ToLower(),
               
            };

            return account;
        }

        public async Task<Models.Account> Authenticate(AuthenticateRequest request)
        {
            try
            {
                var user = await _context.Account
                                .Include(x => x.Uloga)
                                .Include(x => x.Korisnik)
                                .FirstOrDefaultAsync(x => x.KorisničkoIme == request.Username);
                

                if (user != null)
                {
                    var hash = PasswordHelper.GenerateHash(user.PasswordSalt, request.Password);
                    if (hash == user.PasswordHash)
                    {
                        var mapUser = _mapper.Map<Models.Account>(user);
                        return mapUser;
                    }
                }

                return null;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public List<Models.Account> Get()
        {
            var list = _context.Account.ToList();

            return _mapper.Map<List<Models.Account>>(list);
        }
    }
}
