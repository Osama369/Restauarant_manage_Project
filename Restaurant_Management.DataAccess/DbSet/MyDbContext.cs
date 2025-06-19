using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restauarant_Management.Models.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Restaurant_Management.DataAccess.DbSet
{
    public class MyDbContext : IdentityDbContext<IdentityUser>
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Auth> Auth { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Gl_Ledger> Gl_Ledger { get; set; }
        public DbSet<Gl_Type> Gl_Type { get; set; }
        public DbSet<Mode> Mode { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Screen> Screen { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
