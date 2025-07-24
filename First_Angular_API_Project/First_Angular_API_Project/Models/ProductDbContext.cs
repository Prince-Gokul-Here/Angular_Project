using Microsoft.EntityFrameworkCore;
namespace First_Angular_API_Project.Models
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {
        
        }

        public DbSet<Product> Products { get; set; }
    }
}
