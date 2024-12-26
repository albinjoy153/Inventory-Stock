using Microsoft.EntityFrameworkCore;
using InventoryProject.Model;  // Ensure you're using the correct namespace

namespace InventoryProject
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Reference to the Product model for EF Core
        public DbSet<ProductModel> Products { get; set; }

        // Optional: Add DbSet for variants if you want to store them separately
        // public DbSet<Variant> Variants { get; set; }

        
    }
}
