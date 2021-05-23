using BeFirst.WebAPI.Helpers;
using System;
using System.Collections.Generic;

namespace BeFirst.WebAPI.Database
{
    public partial class Korisnik
    {
        public Korisnik()
        {
          
            RadniNalog = new HashSet<RadniNalog>();
        }

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Grad { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int AccountId { get; set; }
        public int UgovorId { get; set; }
        public int? PaketId { get; set; }
        public string Komentar { get; set; }
        public VrstaKorisnika VrstaKorisnika { get; set; }

        public virtual Account Account { get; set; }
        public virtual Paket Paket { get; set; }
        public virtual Ugovor Ugovor { get; set; }
        public virtual ICollection<RadniNalog> RadniNalog { get; set; }
    }
}
