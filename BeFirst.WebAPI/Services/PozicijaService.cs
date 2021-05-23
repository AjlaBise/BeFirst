using AutoMapper;
using BeFirst.Models;
using BeFirst.WebAPI.Database;
using BeFirst.WebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services
{
    public class PozicijaService : IPozicijeService
    {
        private readonly BeFirstContext _pozicija;
        private readonly IMapper _mapper;

        public PozicijaService(BeFirstContext pozicija, IMapper mapper)
        {
            _pozicija = pozicija;
            _mapper = mapper;
        }
        public List<Pozicija> Get()
        {
            var list = _pozicija.Pozicije.ToList();

            return _mapper.Map<List<Models.Pozicija>>(list);
        }
    }
}
