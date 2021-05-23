using System;
using System.Collections.Generic;

namespace BeFirst.WebAPI.Database
{
    public partial class Account
    {
        public Account()
        {
            Korisnik = new HashSet<Korisnik>();
            Uposlenik = new HashSet<Uposlenik>();
            Administrator = new HashSet<Administrator>();
        }

        public int Id { get; set; }
        public string KorisničkoIme { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public int UlogaId { get; set; }

      
        public virtual Uloge Uloga { get; set; }
        public virtual ICollection<Korisnik> Korisnik { get; set; }
        public virtual ICollection<Uposlenik> Uposlenik { get; set; }
        public virtual ICollection<Administrator> Administrator { get; set; }
    }
}
