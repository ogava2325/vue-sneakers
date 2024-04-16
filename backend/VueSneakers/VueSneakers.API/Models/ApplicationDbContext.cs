using Microsoft.EntityFrameworkCore;

namespace VueSneakers.API.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Item> Items { get; set; }
    public DbSet<Favorite> Favorites { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Item>().HasData(
            new Item
            {
                Id = 5, Title = "Мужские Кроссовки Nike Blazer Mid Suede", Price = 123,
                ImageUrl = "/sneakers/sneakers-1.jpg"
            },
            new Item
            {
                Id = 6, Title = "Мужские Кроссовки Nike Blazer Mid Suede", Price = 123,
                ImageUrl = "/sneakers/sneakers-2.jpg"
            },
            new Item
            {
                Id = 7, Title = "Мужские Кроссовки Nike Blazer Mid Suede", Price = 123,
                ImageUrl = "/sneakers/sneakers-3.jpg"
            },
            new Item
            {
                Id = 8, Title = "Мужские Кроссовки Nike Blazer Mid Suede", Price = 123,
                ImageUrl = "/sneakers/sneakers-4.jpg"
            },
            new Item
            {
                Id = 9, Title = "Мужские Кроссовки Nike Blazer Mid Suede", Price = 123,
                ImageUrl = "/sneakers/sneakers-5.jpg"
            },
            new Item
            {
                Id = 10, Title = "Мужские Кроссовки Nike Blazer Mid Suede", Price = 123,
                ImageUrl = "/sneakers/sneakers-6.jpg"
            }
        );
    }
}