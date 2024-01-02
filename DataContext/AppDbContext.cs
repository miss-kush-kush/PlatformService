using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.DataContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
            
        }

        public DbSet<Platform> Platforms { get; set; }
    }
}
