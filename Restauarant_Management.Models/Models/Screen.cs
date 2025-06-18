using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauarant_Management.Models.Models
{
    public class Screen
    {
        public int id { get; set; }
        public string name { get; set; }

        public ICollection<Auth>? auths { get; set; }
    }
}
