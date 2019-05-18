using Microsoft.EntityFrameworkCore;

namespace WebCoreProjekt.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ):base(options)
        {
            
        }
        public DbSet<Samochod> Samochody  { get; set; }
    }
}
