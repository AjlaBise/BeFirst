using System;
using System.Collections.Generic;
using System.Text;

namespace BeFirst.Models
{
    public class Account
    {
        public string KorisničkoIme { get; set; }
        public string Password { get; set; }
        public Uloga Uloga { get; set; }
        public int UlogaId { get; set; }
        public ICollection<Korisnik> Korisnik { get; set; }
    }
}
