using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauarant_Management.Models.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }

        public decimal purcahsePrice { get; set; }
        public decimal salePrice { get; set; }
        public string imageUrl { get; set; }


        // ledgers collections

        public ICollection<Gl_Ledger>? ledgers { get; set; }
    }
}
