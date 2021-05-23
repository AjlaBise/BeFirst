using System;
using System.Collections.Generic;
using System.Text;

namespace BeFirst.Models
{
    public partial class Uposlenik
    {
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
    }
}
