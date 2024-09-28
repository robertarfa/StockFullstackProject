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

    public DbSet<CategoryModel> Categories { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {

        builder.Entity<ProductModel>()
            .HasOne(p => p.Category) // Um produto pertence a uma categoria
            .WithMany() // Uma categoria pode ter muitos produtos (não estamos definindo a propriedade de navegação aqui)
            .HasForeignKey(p => p.CategoryId); // Define a chave estrangeira
    }



}