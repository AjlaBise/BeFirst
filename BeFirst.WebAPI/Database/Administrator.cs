using System;
using System.Collections.Generic;

namespace BeFirst.WebAPI.Database
{
    public partial class Administrator
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public virtual Account Account { get; set; }
        public int AccountId { get; set; }
    }
}
