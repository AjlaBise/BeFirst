using System;
using System.Collections.Generic;
using System.Text;

namespace BeFirst.Models
{
    public partial class OpremaUposlenikRadniNalog
    {
        public int RadniNalogId { get; set; }
        public int OpremaId { get; set; }
        public int UposlenikId { get; set; }
    }
}
