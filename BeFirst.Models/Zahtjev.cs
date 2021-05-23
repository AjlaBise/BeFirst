using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BeFirst.Models
{
    public class Zahtjev
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public string Odgovor { get; set; }
        public int KorisnikId { get; set; }
        [DefaultValue(false)]
        public bool? Odgovoreno { get; set; } = false;
        [DefaultValue(false)]
        public bool? Pogledno { get; set; } = false;
    }
}
