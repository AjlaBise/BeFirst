using BeFirst.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Services.Interfaces
{
    public interface IReportService
    {
        int GetRadniNalogCount(ReportSearchRequest request);

        int GetRadniNalogSum (ReportSearchRequest request);

        int GetBrojOprema(ReportSearchRequest request);
    }
}

