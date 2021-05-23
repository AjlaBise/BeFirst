using System;
using System.Collections.Generic;

namespace BeFirst.WebAPI.Database
{
    public partial class Paket
    {
        public Paket()
        {
            Korisnik = new HashSet<Korisnik>();
        }

        public int Id { get; set; }
        public bool CaTv { get; set; }
        public int? InternetId { get; set; }
        public int? UgovorId { get; set; }

        public bool? Snizen { get; set; }

        public int PaketNamjenaId { get; set; }
        public PaketNamjena PaketNamjena { get; set; }

        public virtual Internet Internet { get; set; }
        public virtual Ugovor Ugovor { get; set; }
        public virtual ICollection<Korisnik> Korisnik { get; set; }
    }
}
