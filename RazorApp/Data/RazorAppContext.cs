using Microsoft.EntityFrameworkCore;
using RazorApp.Models;

namespace RazorApp.Data
{
    public class RazorAppContext : DbContext
    {
        public RazorAppContext(DbContextOptions<RazorAppContext> options)
            : base(options)
        {
        }

        public DbSet<Workout> Workout { get; set; } = default!;
    }
}