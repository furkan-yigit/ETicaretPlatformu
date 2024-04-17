using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.InfraStructure.EntityTypeConfiguration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.InfraStructure.Context
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartLine> CartLines { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseSqlServer("Server=DESKTOP-NNPAIJ5;Database=01-Eticaret;Uid=sa;Pwd=789");
            optionsBuilder.UseSqlServer("Server=DESKTOP-JI3UVS4;Database=OnioneTicaretprojectapp;Uid=sa;Pwd=123");            
            //optionsBuilder.UseSqlServer("Server=DESKTOP-G2S16HQ;Database=OnionETicaretProjectApp;Uid=sa;Pwd=123");
            //optionsBuilder.UseSqlServer("Server=DESKTOP-2H8QNDE;Database=OnionETicaretProjectApp;Uid=sa;Pwd=123");
            //optionsBuilder.UseSqlServer("Server=DESKTOP-FJ8OJV2;Database=ETicaretApp;Uid=sa;Pwd=789");
            //optionsBuilder.UseSqlServer("Server=DESKTOP-LLGUTIH;Database=ETicaretApp;Uid=sa;Pwd=123");

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = "Admin",
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = new Guid().ToString(),
            },
            new IdentityRole
            {
                Id = "Member",
                Name = "Member",
                NormalizedName = "MEMBER",
                ConcurrencyStamp = new Guid().ToString(),
            });


            #region Admin Seed Data
            var adminUser = new User
            {
                Id = "1",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                FirstName = "admin",
                LastName = "admin",
                CreateDate = DateTime.Now,
                ImagePath = $"/images/01-admin.jpg",
                Status = Domain.Enums.Status.Active,
                EmailConfirmed = true
            };

            var passwordHasher = new PasswordHasher<User>();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "1234");

            builder.Entity<User>().HasData(adminUser);
            builder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = "Admin",
                        UserId = adminUser.Id
                    });
            #endregion

            #region Category Seed Data
            var categories = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = "Electronics",
                    Description = "Electronic Products",
                    CreateDate = DateTime.Now,
                    Status = Domain.Enums.Status.Active
                },
                new Category
                {
                    Id = 2,
                    Name = "Clothing",
                    Description = "Clothing Products",
                    CreateDate = DateTime.Now,
                    Status = Domain.Enums.Status.Active
                },
                new Category
                {
                    Id = 3,
                    Name = "Home & Living",
                    Description = "Home and Living Products",
                    CreateDate = DateTime.Now,
                    Status = Domain.Enums.Status.Active
                },
                new Category
                {
                    Id = 4,
                    Name = "Books",
                    Description = "Books",
                    CreateDate = DateTime.Now,
                    Status = Domain.Enums.Status.Active
                },
                new Category
                {
                    Id = 5,
                    Name = "Sports & Outdoor",
                    Description = "Sports and Outdoor Products",
                    CreateDate = DateTime.Now,
                    Status = Domain.Enums.Status.Active
                }
            };
            builder.Entity<Category>().HasData(categories);
            #endregion

            #region Product Seed Data
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Smart Phone",
                    Description = "Next Generation Smart Phone",
                    Price = 2000,
                    StockQuantity = 100,
                    CategoryId = 1,
                    CreateDate = DateTime.Now,
                    Status = Domain.Enums.Status.Active,
                    ImagePath = "/images/ProductImages/smartPhone.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Headphones",
                    Description = "Wireless Headphones",
                    Price = 100,
                    StockQuantity = 200,
                    CategoryId = 1,
                    CreateDate = DateTime.Now,
                    Status = Domain.Enums.Status.Active,
                    ImagePath = "/images/ProductImages/HeadPhones.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "Dress",
                    Description = "New Season Women's Dress",
                    Price = 150,
                    StockQuantity = 150,
                    CategoryId = 2,
                    CreateDate = DateTime.Now,
                    Status = Domain.Enums.Status.Active,
                    ImagePath = "/images/ProductImages/Dress.jpg"
                },
                new Product
                {
                    Id = 4,
                    Name = "Shirt",
                    Description = "Slim Fit Men's Shirt",
                    Price = 80,
                    StockQuantity = 120,
                    CategoryId = 2,
                    CreateDate = DateTime.Now,
                    Status = Domain.Enums.Status.Active,
                    ImagePath = "/images/ProductImages/Shirt.jpg"
                },
                new Product
                {
                    Id = 5,
                    Name = "Kitchen Robot",
                    Description = "5-Function Kitchen Robot",
                    Price = 300,
                    StockQuantity = 80,
                    CategoryId = 3,
                    CreateDate = DateTime.Now,
                    Status = Domain.Enums.Status.Active,
                    ImagePath = "/images/ProductImages/KitchenRobot.jpg"
                },
                new Product
                {
                    Id = 6,
                    Name = "Houseplant",
                    Description = "Flowering Houseplant",
                    Price = 50,
                    StockQuantity = 300,
                    CategoryId = 3,
                    CreateDate = DateTime.Now,
                    Status = Domain.Enums.Status.Active,
                    ImagePath = "/images/ProductImages/HousePlant.jpg"
                },
                new Product
                {
                    Id = 7,
                    Name = "Fiction Novel",
                    Description = "Latest Science Fiction Novel",
                    Price = 20,
                    StockQuantity = 500,
                    CategoryId = 4,
                    CreateDate = DateTime.Now,
                    Status = Domain.Enums.Status.Active,
                    ImagePath = "/images/ProductImages/ScienceFictionNovel.jpg"
                },
                new Product
                {
                    Id = 8,
                    Name = "History Book",
                    Description = "Ottoman Empire History Book",
                    Price = 30,
                    StockQuantity = 400,
                    CategoryId = 4,
                    CreateDate = DateTime.Now,
                    Status = Domain.Enums.Status.Active,
                    ImagePath = "/images/ProductImages/HistoryBook.jpg"
                },
                new Product
                {
                    Id = 9,
                    Name = "Yoga Mat",
                    Description = "Yoga Exercise Mat",
                    Price = 25,
                    StockQuantity = 200,
                    CategoryId = 5,
                    CreateDate = DateTime.Now,
                    Status = Domain.Enums.Status.Active,
                    ImagePath = "/images/ProductImages/YogaMat.jpg"
                },
                new Product
                {
                    Id = 10,
                    Name = "Camping Tent",
                    Description = "2-Person Camping Tent",
                    Price = 150,
                    StockQuantity = 100,
                    CategoryId = 5,
                    CreateDate = DateTime.Now,
                    Status = Domain.Enums.Status.Active,
                    ImagePath = "/images/ProductImages/CampingTent.jpg"

                }
            };
            builder.Entity<Product>().HasData(products);
            #endregion

            builder.ApplyConfiguration(new CartLineConfig());
            builder.ApplyConfiguration(new CartConfig());

            // En Altta
            base.OnModelCreating(builder);

        }
    }
}
