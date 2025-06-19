using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauarant_Management.Models.Models
{
    public class LoginViewModel
    {
       
        public string? Email { get; set; }

      
        public string? Password { get; set; }


       
        public bool? RememberMe { get; set; }

    }
}
