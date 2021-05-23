using System;
using System.Collections.Generic;

namespace BeFirst.WebAPI.Database
{
    public partial class Pozicije
    {
        public Pozicije()
        {
            Uposlenik = new HashSet<Uposlenik>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Uposlenik> Uposlenik { get; set; }
    }
}
