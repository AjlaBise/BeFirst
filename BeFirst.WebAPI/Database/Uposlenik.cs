using System;
using System.Collections.Generic;

namespace BeFirst.WebAPI.Database
{
    public partial class Uposlenik
    {
        public Uposlenik()
        {
            OpremaUposlenikRadnoNalog = new HashSet<OpremaUposlenikRadnoNalog>();
        }

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        public string Grad { get; set; }
        public string Email { get; set; }
        public double Plata { get; set; }
        public bool Aktivan { get; set; }
        public int PozicijaId { get; set; }
        public int UgovorId { get; set; }
        public int? AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Pozicije Pozicija { get; set; }
        public virtual Ugovor Ugovor { get; set; }
        public virtual ICollection<OpremaUposlenikRadnoNalog> OpremaUposlenikRadnoNalog { get; set; }
    }
}
