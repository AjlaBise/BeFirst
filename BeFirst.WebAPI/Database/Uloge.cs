using System;
using System.Collections.Generic;

namespace BeFirst.WebAPI.Database
{
    public partial class Uloge
    {
        public Uloge()
        {
            Account = new HashSet<Account>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Account> Account { get; set; }
    }
}
