using System;
using System.Collections.Generic;

namespace BeFirst.WebAPI.Database
{
    public partial class OpremaUposlenikRadnoNalog
    {
        public int Id { get; set; }
        public int RadniNalogId { get; set; }
        public int OpremaId { get; set; }
        public int UposlenikId { get; set; }

        public virtual Oprema Oprema { get; set; }
        public virtual RadniNalog RadniNalog { get; set; }
        public virtual Uposlenik Uposlenik { get; set; }
    }
}
