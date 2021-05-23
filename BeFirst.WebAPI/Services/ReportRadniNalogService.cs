using AutoMapper;
using BeFirst.Models.Requests;
using BeFirst.WebAPI.Database;
using BeFirst.WebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services
{
    public class ReportRadniNalogService : IReportService
    {
        private readonly BeFirstContext _context;
        private readonly IMapper _mapper;

        public ReportRadniNalogService(BeFirstContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int GetRadniNalogCount(ReportSearchRequest request)
        {
            if (request != null)
            {
                return _context.RadniNalog
                    .Where(x => x.Datum.Month == request.Month && x.Datum.Year == request.Year).ToList().Count();
            }

            return _context.RadniNalog.ToList().Count();
        }

        public int GetRadniNalogSum(ReportSearchRequest request)
        {
            double sum = 0;

             sum = _context.Oprema
             .Join(_context.OpremaUposlenikRadnoNalog,
             o => o.Id,
             rn => rn.OpremaId,
             (o, rn) => new { OpremaUposlenikRadnoNalog = rn, Oprema = 0 })
             .Join(_context.RadniNalog,
             entry => entry.OpremaUposlenikRadnoNalog.RadniNalogId,
             i => i.Id,
             (entry, i) => new { OpremaUposlenikRadnoNalog = entry, RadniNalog = i, Oprema = entry.OpremaUposlenikRadnoNalog.Oprema })
             .Where(x => x.RadniNalog.Datum.Month == request.Month && x.RadniNalog.Datum.Year == request.Year)
             .Sum(x => x.Oprema.Cijena);

            return (int)sum;

        }

        public int GetBrojOprema(ReportSearchRequest request)
        {

            double sum = 0;

            sum = _context.Oprema
            .Join(_context.OpremaUposlenikRadnoNalog,
            o => o.Id,
            rn => rn.OpremaId,
            (o, rn) => new { OpremaUposlenikRadnoNalog = rn, Oprema = 0 })
            .Join(_context.RadniNalog,
            entry => entry.OpremaUposlenikRadnoNalog.RadniNalogId,
            i => i.Id,
            (entry, i) => new { OpremaUposlenikRadnoNalog = entry, RadniNalog = i, Oprema = entry.OpremaUposlenikRadnoNalog.Oprema })
            .Where(x => x.RadniNalog.Datum.Month == request.Month && x.RadniNalog.Datum.Year == request.Year)
            .Sum(x => x.Oprema.Id);

            return (int)sum;
        }
    }
}
