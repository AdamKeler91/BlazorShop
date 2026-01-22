using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Data;

public class ShopDbContext : DbContext
{
    public ShopDbContext(DbContextOptions<ShopDbContext> options)
        : base(options)
    {
    }

    // DbSety dodamy później, np.:
    // public DbSet<Product> Products => Set<Product>();
}
