using System;
using System.Collections.Generic;

namespace BeFirst.WebAPI.Database
{
    public partial class Zahtjev
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public string Odgovor { get; set; }
        public int KorisnikId { get; set; }
        public string KorisnikIme { get; set; }
        public bool? Odgovoreno { get; set; }
        public bool? Pogledno { get; set; }

        public virtual Korisnik Korisnik { get; set; }
    }
}
