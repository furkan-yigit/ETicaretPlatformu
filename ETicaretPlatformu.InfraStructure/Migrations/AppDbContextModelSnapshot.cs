﻿// <auto-generated />
using System;
using ETicaretPlatformu.InfraStructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ETicaretPlatformu.InfraStructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ETicaretPlatformu.Domain.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("ETicaretPlatformu.Domain.Entities.CartLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartLines");
                });

            modelBuilder.Entity("ETicaretPlatformu.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
<<<<<<< HEAD
                            CreateDate = new DateTime(2024, 4, 11, 18, 9, 26, 97, DateTimeKind.Local).AddTicks(5595),
                            Description = "Elektronik Ürünler",
                            Name = "Elektronik",
                            Status = 1
=======
                            CreateDate = new DateTime(2024, 4, 14, 10, 56, 22, 993, DateTimeKind.Local).AddTicks(3665),
                            Description = "Elektronik Ürünler",
                            Name = "Elektronik",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 4, 14, 10, 56, 22, 993, DateTimeKind.Local).AddTicks(3675),
                            Description = "Giyim Ürünleri",
                            Name = "Giyim",
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 4, 14, 10, 56, 22, 993, DateTimeKind.Local).AddTicks(3676),
                            Description = "Ev ve Yaşam Ürünleri",
                            Name = "Ev & Yaşam",
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2024, 4, 14, 10, 56, 22, 993, DateTimeKind.Local).AddTicks(3678),
                            Description = "Kitaplar",
                            Name = "Kitap",
                            Status = 1
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2024, 4, 14, 10, 56, 22, 993, DateTimeKind.Local).AddTicks(3679),
                            Description = "Spor ve Outdoor Ürünleri",
                            Name = "Spor & Outdoor",
                            Status = 1
>>>>>>> origin/master
                        });
                });

            modelBuilder.Entity("ETicaretPlatformu.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ETicaretPlatformu.Domain.Entities.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ETicaretPlatformu.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
<<<<<<< HEAD
                            CreateDate = new DateTime(2024, 4, 11, 18, 9, 26, 97, DateTimeKind.Local).AddTicks(5613),
=======
                            CreateDate = new DateTime(2024, 4, 14, 10, 56, 22, 993, DateTimeKind.Local).AddTicks(3726),
>>>>>>> origin/master
                            Description = "Next Generation Smart Phone",
                            ImagePath = "/images/ProductImages/smartPhone.jpg",
                            Name = "Smart Phone",
                            Price = 2000m,
                            Status = 1,
                            StockQuantity = 100
<<<<<<< HEAD
=======
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreateDate = new DateTime(2024, 4, 14, 10, 56, 22, 993, DateTimeKind.Local).AddTicks(3731),
                            Description = "Wireless Headphones",
                            ImagePath = "/images/ProductImages/HeadPhones.jpg",
                            Name = "Headphones",
                            Price = 100m,
                            Status = 1,
                            StockQuantity = 200
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreateDate = new DateTime(2024, 4, 14, 10, 56, 22, 993, DateTimeKind.Local).AddTicks(3734),
                            Description = "New Season Women's Dress",
                            ImagePath = "/images/ProductImages/Dress.jpg",
                            Name = "Dress",
                            Price = 150m,
                            Status = 1,
                            StockQuantity = 150
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreateDate = new DateTime(2024, 4, 14, 10, 56, 22, 993, DateTimeKind.Local).AddTicks(3736),
                            Description = "Slim Fit Men's Shirt",
                            ImagePath = "/images/ProductImages/Shirt.jpg",
                            Name = "Shirt",
                            Price = 80m,
                            Status = 1,
                            StockQuantity = 120
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            CreateDate = new DateTime(2024, 4, 14, 10, 56, 22, 993, DateTimeKind.Local).AddTicks(3748),
                            Description = "5-Function Kitchen Robot",
                            ImagePath = "/images/ProductImages/KitchenRobot.jpg",
                            Name = "Kitchen Robot",
                            Price = 300m,
                            Status = 1,
                            StockQuantity = 80
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            CreateDate = new DateTime(2024, 4, 14, 10, 56, 22, 993, DateTimeKind.Local).AddTicks(3751),
                            Description = "Flowering Houseplant",
                            ImagePath = "/images/ProductImages/HousePlant.jpg",
                            Name = "Houseplant",
                            Price = 50m,
                            Status = 1,
                            StockQuantity = 300
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 4,
                            CreateDate = new DateTime(2024, 4, 14, 10, 56, 22, 993, DateTimeKind.Local).AddTicks(3753),
                            Description = "Latest Science Fiction Novel",
                            ImagePath = "/images/ProductImages/ScienceFictionNovel.jpg",
                            Name = "Fiction Novel",
                            Price = 20m,
                            Status = 1,
                            StockQuantity = 500
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            CreateDate = new DateTime(2024, 4, 14, 10, 56, 22, 993, DateTimeKind.Local).AddTicks(3755),
                            Description = "Ottoman Empire History Book",
                            ImagePath = "/images/ProductImages/HistoryBook.jpg",
                            Name = "History Book",
                            Price = 30m,
                            Status = 1,
                            StockQuantity = 400
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 5,
                            CreateDate = new DateTime(2024, 4, 14, 10, 56, 22, 993, DateTimeKind.Local).AddTicks(3757),
                            Description = "Yoga Exercise Mat",
                            ImagePath = "/images/ProductImages/YogaMat.jpg",
                            Name = "Yoga Mat",
                            Price = 25m,
                            Status = 1,
                            StockQuantity = 200
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 5,
                            CreateDate = new DateTime(2024, 4, 14, 10, 56, 22, 993, DateTimeKind.Local).AddTicks(3760),
                            Description = "2-Person Camping Tent",
                            ImagePath = "/images/ProductImages/CampingTent.jpg",
                            Name = "Camping Tent",
                            Price = 150m,
                            Status = 1,
                            StockQuantity = 100
>>>>>>> origin/master
                        });
                });

            modelBuilder.Entity("ETicaretPlatformu.Domain.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
<<<<<<< HEAD
                            ConcurrencyStamp = "9c8d9966-472c-4be4-ad61-124d589f8040",
                            CreateDate = new DateTime(2024, 4, 11, 18, 9, 26, 96, DateTimeKind.Local).AddTicks(3036),
=======
                            ConcurrencyStamp = "9a65583c-a4f5-4b4c-8306-a23b6eaf7a28",
                            CreateDate = new DateTime(2024, 4, 14, 10, 56, 22, 983, DateTimeKind.Local).AddTicks(6681),
>>>>>>> origin/master
                            Email = "admin@example.com",
                            EmailConfirmed = true,
                            FirstName = "admin",
                            ImagePath = "/images/01-admin.jpg",
                            LastName = "admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN",
<<<<<<< HEAD
                            PasswordHash = "AQAAAAEAACcQAAAAEHqK1JjnWyIRCGOU6SRWqns+NALNRS0PiNJAMh1iZ2VQy5DRvUqPDRhNBcvtNXrXMw==",
                            PaymentMethod = 0,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4f0046c6-202f-4a7a-ab34-36c828af5fe9",
=======
                            PasswordHash = "AQAAAAEAACcQAAAAEEyiFTNrXDaNTZf9BaBzfJKhPUkQtRDdCXapxwi/qpU70yrB2W3i7THdqEazv/hk2g==",
                            PaymentMethod = 0,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d3c49727-abf8-464b-b828-068ccb48d3a3",
>>>>>>> origin/master
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "Admin",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "Member",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "Member",
                            NormalizedName = "MEMBER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "Admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ETicaretPlatformu.Domain.Entities.Cart", b =>
                {
                    b.HasOne("ETicaretPlatformu.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ETicaretPlatformu.Domain.Entities.CartLine", b =>
                {
                    b.HasOne("ETicaretPlatformu.Domain.Entities.Cart", "Cart")
                        .WithMany("CartLines")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ETicaretPlatformu.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ETicaretPlatformu.Domain.Entities.Order", b =>
                {
                    b.HasOne("ETicaretPlatformu.Domain.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ETicaretPlatformu.Domain.Entities.OrderDetail", b =>
                {
                    b.HasOne("ETicaretPlatformu.Domain.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ETicaretPlatformu.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ETicaretPlatformu.Domain.Entities.Product", b =>
                {
                    b.HasOne("ETicaretPlatformu.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ETicaretPlatformu.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ETicaretPlatformu.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ETicaretPlatformu.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ETicaretPlatformu.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ETicaretPlatformu.Domain.Entities.Cart", b =>
                {
                    b.Navigation("CartLines");
                });

            modelBuilder.Entity("ETicaretPlatformu.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ETicaretPlatformu.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("ETicaretPlatformu.Domain.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
