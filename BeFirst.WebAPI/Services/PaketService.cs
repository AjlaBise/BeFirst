using AutoMapper;
using BeFirst.Models;
using BeFirst.WebAPI.Database;
using BeFirst.WebAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services
{
    public class PaketService : IPaketService
    {
        private readonly BeFirstContext _context;
        private readonly IMapper _mapper;

        public PaketService(BeFirstContext paket, IMapper mapper)
        {
            _context = paket;
            _mapper = mapper;
        }

        public bool Delete(int id)
        {
            // Brisanje paketa iz tabele Korisnici
            var korisnici = _context.Korisnik.Where(x => x.PaketId == id).ToList();
            korisnici.ForEach(x => x.PaketId = null);
            _context.SaveChanges();

            // Brisanje paketa
            var entity = _context.Paket.Find(id);
            if (entity != null)
            {
                _context.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Models.Paket> Get()
        {
            var list = _context.Paket.Include(x => x.PaketNamjena).ToList();

            return _mapper.Map<List<Models.Paket>>(list);
        }

        public Models.Paket GetById(int id)
        {
            var paket = _context.Paket.Where(k => k.Id == id).Single();

            return _mapper.Map<Models.Paket>(paket);
        }

        public Models.Paket Insert(Models.Paket paket)
        {
            var PaketEntity = _mapper.Map<Database.Paket>(paket);

            _context.Paket.Add(PaketEntity);
            _context.SaveChanges();

            return _mapper.Map<Models.Paket>(PaketEntity);
        }

        public Models.Paket Update(int id, Models.Paket paket)
        {
            var paketEntity = _context.Paket.Find(id);

            _context.Paket.Attach(paketEntity);
            _context.Paket.Update(paketEntity);

            _mapper.Map(paket, paketEntity);

            _context.SaveChanges();

            return _mapper.Map<Models.Paket>(paketEntity);
        }
    }
}
