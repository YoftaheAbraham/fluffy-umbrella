using Microsoft.EntityFrameworkCore;
using fluffy_umbrella.Models;

namespace fluffy_umbrella.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } // Example table
    }
}
