using AutoMapper;
using BeFirst.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnik, Models.Korisnik>().ReverseMap();
            CreateMap<Database.Ugovor, Models.Ugovor>().ReverseMap();
            CreateMap<Database.Ponuda, Models.Ponuda>().ReverseMap();
            CreateMap<Database.Uposlenik, Models.Uposlenik>().ReverseMap();
            CreateMap<Account, Models.Account>()
                .ReverseMap();

            CreateMap<Internet, Models.Internet>().ReverseMap();

            CreateMap<Paket, Models.Paket>().ReverseMap();
                        //  .ForMember(dest => dest.Namjena, opt => opt.MapFrom(src => src.PaketNamjena.Naziv))
            CreateMap<Pozicije, Models.Pozicija>().ReverseMap();
            CreateMap<Oprema, Models.Oprema>().ReverseMap();
            CreateMap<PaketNamjena, Models.VrstaPaketa>().ReverseMap();

            CreateMap<Uloge, Models.Uloga>().ReverseMap();
            CreateMap<Zahtjev, Models.Zahtjev>().ReverseMap();
            CreateMap<RadniNalog, Models.RadniNalog>().ReverseMap();
            CreateMap<OpremaUposlenikRadnoNalog, Models.OpremaUposlenikRadniNalog>().ReverseMap();

        }
    }       
}

