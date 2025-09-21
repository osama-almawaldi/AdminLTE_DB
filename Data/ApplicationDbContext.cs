using Microsoft.EntityFrameworkCore;
using AdminLTE_DB.Models;
namespace AdminLTE_DB.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}