using System;
using System.Collections.Generic;

namespace BeFirst.WebAPI.Database
{
    public partial class RadniNalog
    {
        public RadniNalog()
        {
            OpremaUposlenikRadnoNalog = new HashSet<OpremaUposlenikRadnoNalog>();
        }

        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public string Adresa { get; set; }
        public string OpisPrijavljenogPosla { get; set; }
        public string OpisIzvrsenogPosla { get; set; }
        public int KorisnikId { get; set; }
        public string KorisnikIme { get; set; }
        public string KorisnikPrezime { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual ICollection<OpremaUposlenikRadnoNalog> OpremaUposlenikRadnoNalog { get; set; }
    }
}
