using System.Data.Entity;
namespace BensBurgers.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("BensBurgers")
        {
            //var x = 1; used for debugging, comment out and set a breakpoint to see if the page is generated
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}