using Microsoft.EntityFrameworkCore;
using Blazerize_demo.Models;
using System.Data.Common;

namespace Blazerize_demo.Data
{
    public class WagensContext : DbContext
    {
        public DbSet<Wagen> Wagens { get; set; }
        public WagensContext(DbContextOptions options) : base(options) { }
    }
}
