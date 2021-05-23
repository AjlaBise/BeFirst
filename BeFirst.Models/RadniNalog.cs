using System;

namespace BeFirst.Models
{
    public partial class RadniNalog
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public string Adresa { get; set; }
        public string OpisPrijavljenogPosla { get; set; }
        public string OpisIzvrsenogPosla { get; set; }
        public int KorisnikId { get; set; }
        public string KorisnikIme { get; set; }
        public string KorisnikPrezime { get; set; }
    }
}
