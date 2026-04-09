using EventHorizon_API.Models;
using Microsoft.EntityFrameworkCore;

namespace EventHorizon_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base (options) { }

        public DbSet<User> Users { get; set; }
    }
}
