using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauarant_Management.Models.Models
{
    public  class Customer
    {
        public int id { get; set; }
        public string name { get; set; }

        // collection of legders 

        public ICollection<Gl_Ledger>? ledgers { get; set; }
    }
}
