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
    public class VrstaPaketaServices : IVrstaPaketaServiices
    {
        private readonly BeFirstContext _context;
        private readonly IMapper _mapper;

        public VrstaPaketaServices(BeFirstContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<VrstaPaketa> Get()
        {

            var list = _context.PaketNamjena.ToList();

            return _mapper.Map<List<Models.VrstaPaketa>>(list);
        }
    }
}
