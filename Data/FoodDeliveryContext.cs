using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

public class FoodDeliveryContext : DbContext
{
    public FoodDeliveryContext(DbContextOptions<FoodDeliveryContext> options)
        : base(options) { }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Cuisine> Cuisines { get; set; }
}
