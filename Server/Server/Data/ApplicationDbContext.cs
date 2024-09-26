using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options)
        : base(options) { }


    public DbSet<Pizza> Pizzas { get; set; } = null!;
    public DbSet<Customer> Customer { get; set; } = null!;
    public DbSet<Address> Address { get; set; } = null!;


}