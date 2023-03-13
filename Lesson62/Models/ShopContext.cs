using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Shop.Models
{
    public class ShopContext: DbContext
    {
        public ShopContext(DbContextOptions<ShopContext>options):base(options)
        {
            
        }
        public DbSet<Products> Products { get;set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Brands> Brands { get; set; }
    }
}
