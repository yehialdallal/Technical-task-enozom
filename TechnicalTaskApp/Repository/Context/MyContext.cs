using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Context
{
    public class MyContext : DbContext
    {
        public DbSet<DenormalizedTable> DenormalizedTable { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryProduct> CategoriesProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(10, 4, 24));
            var connectionString = "server=localhost;user=testuser;password=testpassword;database=help";
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DenormalizedTable>().HasData(
        new DenormalizedTable { Id = 1, Product = "HP Laptop 15\"", Categories = "Laptops, Computers, Electronics, HP" },
        new DenormalizedTable { Id = 2, Product = "iPhone 15", Categories = "Mobiles, Electronics, Apple" },
        new DenormalizedTable { Id = 3, Product = "Samsung S23", Categories = "Mobiles, Electronics, Samsung" },
        new DenormalizedTable { Id = 4, Product = "Samsung LED Screen 32\"", Categories = "TVs, Electronics, Samsung" });

            modelBuilder.Entity<Product>().HasData(
        new Product { Id = 1, Name = "HP Laptop 15\""},
        new Product { Id = 2, Name = "iPhone 15" },
        new Product { Id = 3, Name = "Samsung S23" },
        new Product { Id = 4, Name = "Samsung LED Screen 32\"" });

            modelBuilder.Entity<Category>().HasData(
        new Category { Id = 1, Name = "Laptops" },
        new Category { Id = 2, Name = "Mobiles" },
        new Category { Id = 3, Name = "Electronics" },
        new Category { Id = 4, Name = "TVs" },
        new Category { Id = 5 ,Name = "Samsung"},
        new Category { Id = 6, Name = "Computers" },
        new Category { Id = 7 ,Name = " HP"},
        new Category { Id = 8 ,Name = "Apple"});

            modelBuilder.Entity<CategoryProduct>().HasData(
        new CategoryProduct { Id = 1,ProductId = 1, CategoryId = 1 },
        new CategoryProduct { Id = 2, ProductId = 1, CategoryId = 6 },
        new CategoryProduct { Id = 3, ProductId = 1, CategoryId = 3 },
        new CategoryProduct { Id = 4, ProductId = 1, CategoryId = 7 },
        //
        new CategoryProduct { Id = 5, ProductId = 2, CategoryId = 2 },
        new CategoryProduct { Id = 6, ProductId = 2, CategoryId = 3 },
        new CategoryProduct { Id = 7, ProductId = 2, CategoryId = 8 },
        //
        new CategoryProduct { Id = 8, ProductId = 3, CategoryId = 2 },
        new CategoryProduct { Id = 9, ProductId = 3, CategoryId = 3 },
        new CategoryProduct { Id = 10, ProductId = 3, CategoryId = 5 },
         //
        new CategoryProduct { Id = 11, ProductId = 4, CategoryId = 4 },
        new CategoryProduct { Id = 12, ProductId = 4, CategoryId = 3 },
        new CategoryProduct { Id = 13, ProductId = 4, CategoryId = 5 }
    );

        }

    }
}
