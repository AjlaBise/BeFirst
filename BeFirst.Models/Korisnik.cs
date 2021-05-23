using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BeFirst.Models
{
    public partial class Korisnik
    {     
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }  
        public string Adresa { get; set; }
        public string Grad { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }  
        public int UgovorId { get; set; }
        public int PaketId { get; set; }
        public string Komentar { get; set; }
    }
}
