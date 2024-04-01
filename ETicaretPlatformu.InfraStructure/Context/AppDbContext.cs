using ETicaretPlatformu.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.InfraStructure.Context
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseSqlServer("Server=DESKTOP-NNPAIJ5;Database=01-Eticaret;Uid=sa;Pwd=789");
            optionsBuilder.UseSqlServer("Server=DESKTOP-JI3UVS4;Database=OnionETicaretProjectApp;Uid=sa;Pwd=123");
            
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





            // En Altta
            base.OnModelCreating(builder);
            // optionsBuilder.UseSqlServer("Server=DESKTOP-NNPAIJ5;Database=OnionProjectApp;Uid=sa;Pwd=789");
            //optionsBuilder.UseSqlServer("Server=DESKTOP-JI3UVS4;Database=OnionETicaretProjectApp;Uid=sa;Pwd=123");            
            //optionsBuilder.UseSqlServer("Server=DESKTOP-G2S16HQ;Database=OnionETicaretProjectApp;Uid=sa;Pwd=123");            
           // optionsBuilder.UseSqlServer("Server=DESKTOP-FJ8OJV2;Database=ETicaretApp;Uid=sa;Pwd=789");
        }
    }
}
