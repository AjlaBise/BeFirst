using System;
using System.Collections.Generic;

namespace BeFirst.WebAPI.Database
{
    public partial class Oprema
    {
        public Oprema()
        {
            OpremaUposlenikRadnoNalog = new HashSet<OpremaUposlenikRadnoNalog>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public int BrojKomada { get; set; }
        public bool NaStanju { get; set; }
        public double Cijena { get; set; }

        public virtual ICollection<OpremaUposlenikRadnoNalog> OpremaUposlenikRadnoNalog { get; set; }
    }
}
