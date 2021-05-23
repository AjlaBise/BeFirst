using System;
using System.Collections.Generic;

namespace BeFirst.WebAPI.Database
{
    public partial class Ugovor
    {
        public Ugovor()
        {
            Internet = new HashSet<Internet>();
            Korisnik = new HashSet<Korisnik>();
            Paket = new HashSet<Paket>();
            Uposlenik = new HashSet<Uposlenik>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public string BrojUgovora { get; set; }
        public string Sadrzaj { get; set; }

        public virtual ICollection<Internet> Internet { get; set; }
        public virtual ICollection<Korisnik> Korisnik { get; set; }
        public virtual ICollection<Paket> Paket { get; set; }
        public virtual ICollection<Uposlenik> Uposlenik { get; set; }
    }
}
