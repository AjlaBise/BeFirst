using System;
using System.Collections.Generic;
using System.Text;

namespace BeFirst.Models
{
    public class Internet
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Brzina { get; set; }
        public float Cijena { get; set; }
        public string Opis { get; set; }
        public int? UgovorId { get; set; }
    }
}
