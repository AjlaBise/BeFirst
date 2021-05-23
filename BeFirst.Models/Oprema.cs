using System;
using System.Collections.Generic;
using System.Text;

namespace BeFirst.Models
{
    public partial class Oprema
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int BrojKomada { get; set; }
        public bool NaStanju { get; set; }
        public double Cijena { get; set; }
    }
}
