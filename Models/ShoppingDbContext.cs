using Microsoft.EntityFrameworkCore;


public class ShoppingDbContext : ShoppingDbContext
{
    public ShoppingDbContext(DbContextOptions<ShoppingDbContext> opt) : base(opt) { }

}