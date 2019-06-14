using System.Data.Entity;
namespace BensBurgers.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("BensBurgers")
        {
            var x = 1;
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}