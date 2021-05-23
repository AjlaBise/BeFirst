using AutoMapper;
using BeFirst.Models;
using BeFirst.Models.Requests;
using BeFirst.WebAPI.Database;
using BeFirst.WebAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services
{
    public class RecommenderService : IRecommenderService
    {

        private readonly BeFirstContext _context;
        private readonly IMapper _mapper;
        public RecommenderService(BeFirstContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //    Sistem preporuka u aplikaciji će biti implementirana u smislu preporučivanja 
        //    paketa po sniženoj cijeni, veća jačina interneta, studentski paketi.

        //    Ukoliko je neki korisnik uzeo studentski paket, njemu će se prikazivati 
        //    iste ili slične ponude za studente.

        public Models.RecommenderModel Get(int id)
        {
            var UserEntity = _context.Korisnik
                .Include(x => x.Paket)
                .Include(x => x.Paket.PaketNamjena)
                .Where(x => x.Id == id)
                .First();

            var model = new RecommenderModel();

            // Snizeni paketi
            var snizeniPaketi = _context.Paket.Include(x => x.PaketNamjena).Where(x => ((bool)x.Snizen) == true).ToList();
            model.SnizeniPaketi = _mapper.Map<List<Models.Paket>>(snizeniPaketi);

            // Slicni paketi
            var paketNamjenaId = UserEntity.Paket.PaketNamjenaId;
            var slicniPaketi = _context.Paket.Include(x => x.PaketNamjena).Where(x => x.PaketNamjenaId == paketNamjenaId).ToList();
            model.SlicniPaketi = _mapper.Map<List<Models.Paket>>(slicniPaketi);

            return model;
        }
   
    }
}