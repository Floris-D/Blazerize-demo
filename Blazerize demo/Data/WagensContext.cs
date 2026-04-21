using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Blazerize_demo.Models;

namespace Blazerize_demo.Data
{
    public class WagensContext : DbContext
    {
        public DbSet<Wagen> Wagens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
