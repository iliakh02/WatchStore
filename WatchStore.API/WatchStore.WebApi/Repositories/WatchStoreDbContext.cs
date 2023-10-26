using Microsoft.EntityFrameworkCore;
using WatchStore.WebApi.Entities;
using WatchStore.WebApi.MockData;

namespace WatchStore.WebApi.Repositories;

public class WatchStoreDbContext: DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public WatchStoreDbContext()
    {
        
    }

    public WatchStoreDbContext(DbContextOptions<WatchStoreDbContext> options) : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        new DbInitializer(modelBuilder).Seed();
    }
}