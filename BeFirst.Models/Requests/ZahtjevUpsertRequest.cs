using System;
using System.Collections.Generic;
using System.Text;

namespace BeFirst.Models.Requests
{
    public class ZahtjevUpsertRequest
    {
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public int KorisnikID { get; set; }
    }
}
