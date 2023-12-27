using Microsoft.EntityFrameworkCore;
using DockerWebApi.Models;

namespace DockerWebApi.DataContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
            
        }

        public DbSet<Platform> Platforms { get; set; }
    }
}
