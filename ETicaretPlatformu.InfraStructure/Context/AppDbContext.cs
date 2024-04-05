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
            optionsBuilder.UseSqlServer("Server=DESKTOP-NNPAIJ5;Database=01-Eticaret;Uid=sa;Pwd=789");
            //optionsBuilder.UseSqlServer("Server=DESKTOP-JI3UVS4;Database=OnionETicaretProjectApp;Uid=sa;Pwd=123");            
            optionsBuilder.UseSqlServer("Server=DESKTOP-G2S16HQ;Database=OnionETicaretProjectApp;Uid=sa;Pwd=123");
            //optionsBuilder.UseSqlServer("Server=DESKTOP-FJ8OJV2;Database=ETicaretApp;Uid=sa;Pwd=789");
            optionsBuilder.UseSqlServer("Server=DESKTOP-LLGUTIH;Database=ETicaretApp;Uid=sa;Pwd=123");

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


            builder.ApplyConfiguration(new CartLineConfig());
            builder.ApplyConfiguration(new CartConfig());

            // En Altta
            base.OnModelCreating(builder);

        }
    }
}
