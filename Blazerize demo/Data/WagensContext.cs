using Microsoft.EntityFrameworkCore;
using Blazerize_demo.Models;
using System.Data.Common;

namespace Blazerize_demo.Data
{
    public class WagensContext : DbContext
    {
        public DbSet<Wagen> Wagens { get; set; }
        public DbSet<Datum> Datums { get; set; }
        public DbSet<Label> Labels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
        public WagensContext(DbContextOptions options) : base(options) { }

    }
}
