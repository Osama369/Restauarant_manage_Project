using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauarant_Management.Models.Models
{
    public class User
    {
        public int? id { get; set; }
        public string name { get; set; }
        public int? roleId { get; set; }
        public string? userEmail { get; set; } 
        [NotMapped]
        public string? password { get; set; }
       // [NotMapped]
        public string? phone { get; set; }
        public string? identityUserId { get; set; }

        [NotMapped]
        public Role? roles { get; set; }   // Role mode use roles ayenge 

        [NotMapped]
        public ICollection<Auth>? auths { get; set; }  // Auth se auths ayenge 
    }
}
