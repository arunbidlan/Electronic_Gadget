using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Electronic_Gadget.Models;

namespace Electronic_Gadget.Data
{
    public class Electronic_GadgetContext : DbContext
    {
        public Electronic_GadgetContext (DbContextOptions<Electronic_GadgetContext> options)
            : base(options)
        {
        }

        public DbSet<Electronic_Gadget.Models.Brand> Brand { get; set; }

        public DbSet<Electronic_Gadget.Models.Category> Category { get; set; }

        public DbSet<Electronic_Gadget.Models.Customer> Customer { get; set; }

        public DbSet<Electronic_Gadget.Models.Order> Order { get; set; }

        public DbSet<Electronic_Gadget.Models.Product> Product { get; set; }
    }
}
