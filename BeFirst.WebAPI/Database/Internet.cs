using System;
using System.Collections.Generic;

namespace BeFirst.WebAPI.Database
{
    public partial class Internet
    {
        public Internet()
        {
            Paket = new HashSet<Paket>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Brzina { get; set; }
        public float Cijena { get; set; }
        public string Opis { get; set; }
        public int? UgovorId { get; set; }

        public virtual Ugovor Ugovor { get; set; }
        public virtual ICollection<Paket> Paket { get; set; }
    }
}
