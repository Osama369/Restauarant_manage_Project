using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauarant_Management.Models.Models
{
    public class Auth
    {
        public int id { get; set; }

        public string? screenId { get; set; }  // FK
        public string? userId { get; set; }   // FK

        public bool canAdd { get; set; }
        public bool canRemove { get; set; }
        public bool canView { get; set; }
        public bool canUpdate { get; set; }


        // auth me user and screens honge 

        public User? users { get; set; }  // Navigational prop ef core 
        public Screen? screens { get; set; }
    }
}
