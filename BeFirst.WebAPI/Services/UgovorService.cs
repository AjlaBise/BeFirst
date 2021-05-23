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
    public class UgovorService : IUgovorService
    {
        private readonly BeFirstContext _ugovor;
        private readonly IMapper _mapper;

        public UgovorService(BeFirstContext ugovor, IMapper mapper)
        {
            _ugovor = ugovor;
            _mapper = mapper;
        }
        public List<Models.Ugovor> Get()
        {
            var list = _ugovor.Ugovor.ToList();

            return _mapper.Map<List<Models.Ugovor>>(list);
        }

        public Models.Ugovor Insert(Models.Ugovor ugovor)
        {
            var UgovorEntity = _mapper.Map<Database.Ugovor>(ugovor);

            _ugovor.Ugovor.Add(UgovorEntity);
            _ugovor.SaveChanges();

            return _mapper.Map<Models.Ugovor>(UgovorEntity);
        }
    }
}
