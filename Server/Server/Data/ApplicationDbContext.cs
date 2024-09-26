using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options)
        : base(options) { }


    public DbSet<Pizza> Pizzas { get; set; } = null!;
    public DbSet<CustomerModel> Customers { get; set; } = null!;
    public DbSet<AddressModel> Address { get; set; } = null!;

    public DbSet<ProductModel> Products { get; set; }

}