using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauarant_Management.Models.Models
{
    public class Gl_Ledger
    {
        public int id { get; set; }
        public int? masetrGlId { get; set; }
        public int? glTypeId { get; set; }  // FK

        public int? modeId { get; set; }  // FK
        public int? supplierId { get; set; }  // Fk

        public int? cutomerId { get; set; }  // FK
        public int productId { get; set; }    // FK
        public  int  quantity { get; set; }
        public decimal price { get; set; }
        public decimal discount { get; set; }
        public decimal tax { get; set; }
        public decimal amount { get; set; }
        public string? invoiveNumber { get; set; }
        public DateTime? transactionDate { get; set; }

        public Supplier? suppliers { get; set; }
        public Mode? modes { get; set; }
        public Gl_Type? glTypes { get; set; }
        public Customer? customers  { get; set; } 



    }
}
