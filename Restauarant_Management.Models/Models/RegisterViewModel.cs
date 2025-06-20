using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauarant_Management.Models.Models
{
    public class RegisterViewModel
    {
       
        public string? UserName { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? Password { get; set; }

        public int? roleId {get; set; }

        public string? ConfirmPassword { get; set; }
    }
}
