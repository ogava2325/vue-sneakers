﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VueSneakers.API.Models;

#nullable disable

namespace VueSneakers.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VueSneakers.API.Models.Favorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("VueSneakers.API.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            ImageUrl = "/sneakers/sneakers-1.jpg",
                            Price = 123m,
                            Title = "Мужские Кроссовки Nike Blazer Mid Suede"
                        },
                        new
                        {
                            Id = 6,
                            ImageUrl = "/sneakers/sneakers-2.jpg",
                            Price = 123m,
                            Title = "Мужские Кроссовки Nike Blazer Mid Suede"
                        },
                        new
                        {
                            Id = 7,
                            ImageUrl = "/sneakers/sneakers-3.jpg",
                            Price = 123m,
                            Title = "Мужские Кроссовки Nike Blazer Mid Suede"
                        },
                        new
                        {
                            Id = 8,
                            ImageUrl = "/sneakers/sneakers-4.jpg",
                            Price = 123m,
                            Title = "Мужские Кроссовки Nike Blazer Mid Suede"
                        },
                        new
                        {
                            Id = 9,
                            ImageUrl = "/sneakers/sneakers-5.jpg",
                            Price = 123m,
                            Title = "Мужские Кроссовки Nike Blazer Mid Suede"
                        },
                        new
                        {
                            Id = 10,
                            ImageUrl = "/sneakers/sneakers-6.jpg",
                            Price = 123m,
                            Title = "Мужские Кроссовки Nike Blazer Mid Suede"
                        });
                });

            modelBuilder.Entity("VueSneakers.API.Models.Favorite", b =>
                {
                    b.HasOne("VueSneakers.API.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });
#pragma warning restore 612, 618
        }
    }
}
