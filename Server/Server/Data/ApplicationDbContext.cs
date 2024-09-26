using Microsoft.EntityFrameworkCore;
using Server.Data.Dtos.Product;
using Server.Models;
using System.Reflection.Emit;

namespace Server.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options)
        : base(options) { }


    //public DbSet<Pizza> Pizzas { get; set; } = null!;
    public DbSet<CustomerModel> Customers { get; set; } = null!;
    public DbSet<AddressModel> Address { get; set; } = null!;

    public DbSet<ProductModel> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {

        //builder.Entity<CreateProductDto>()
        // .HasKey(p => p.);

        //builder.Entity<CreateProductDto>()
        //     .Property(u => u.Category)
        //     .HasConversion<string>();
    }



}