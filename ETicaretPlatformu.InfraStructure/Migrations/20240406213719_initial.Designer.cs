﻿// <auto-generated />
using System;
using ETicaretPlatformu.InfraStructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ETicaretPlatformu.InfraStructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
<<<<<<<< HEAD:ETicaretPlatformu.InfraStructure/Migrations/20240406213719_initial.Designer.cs
    [Migration("20240406213719_initial")]
    partial class initial
========
    [Migration("20240409173208_init")]
    partial class init
>>>>>>>> origin/master:ETicaretPlatformu.InfraStructure/Migrations/20240409173208_init.Designer.cs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
<<<<<<<< HEAD:ETicaretPlatformu.InfraStructure/Migrations/20240406213719_initial.Designer.cs
                            CreateDate = new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2839),
========
                            CreateDate = new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(410),
>>>>>>>> origin/master:ETicaretPlatformu.InfraStructure/Migrations/20240409173208_init.Designer.cs
                            Description = "Elektronik Ürünler",
                            Name = "Elektronik",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
<<<<<<<< HEAD:ETicaretPlatformu.InfraStructure/Migrations/20240406213719_initial.Designer.cs
                            CreateDate = new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2846),
========
                            CreateDate = new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(432),
>>>>>>>> origin/master:ETicaretPlatformu.InfraStructure/Migrations/20240409173208_init.Designer.cs
                            Description = "Giyim Ürünleri",
                            Name = "Giyim",
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
<<<<<<<< HEAD:ETicaretPlatformu.InfraStructure/Migrations/20240406213719_initial.Designer.cs
                            CreateDate = new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2847),
========
                            CreateDate = new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(436),
>>>>>>>> origin/master:ETicaretPlatformu.InfraStructure/Migrations/20240409173208_init.Designer.cs
                            Description = "Ev ve Yaşam Ürünleri",
                            Name = "Ev & Yaşam",
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
<<<<<<<< HEAD:ETicaretPlatformu.InfraStructure/Migrations/20240406213719_initial.Designer.cs
                            CreateDate = new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2848),
========
                            CreateDate = new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(440),
>>>>>>>> origin/master:ETicaretPlatformu.InfraStructure/Migrations/20240409173208_init.Designer.cs
                            Description = "Kitaplar",
                            Name = "Kitap",
                            Status = 1
                        },
                        new
                        {
                            Id = 5,
<<<<<<<< HEAD:ETicaretPlatformu.InfraStructure/Migrations/20240406213719_initial.Designer.cs
                            CreateDate = new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2849),
========
                            CreateDate = new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(443),
>>>>>>>> origin/master:ETicaretPlatformu.InfraStructure/Migrations/20240409173208_init.Designer.cs
                            Description = "Spor ve Outdoor Ürünleri",
                            Name = "Spor & Outdoor",
                            Status = 1
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
                        .IsRequired()
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
<<<<<<<< HEAD:ETicaretPlatformu.InfraStructure/Migrations/20240406213719_initial.Designer.cs
                            CreateDate = new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2879),
========
                            CreateDate = new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(551),
>>>>>>>> origin/master:ETicaretPlatformu.InfraStructure/Migrations/20240409173208_init.Designer.cs
                            Description = "Next Generation Smart Phone",
                            ImagePath = "/images/ProductImages/smartPhone.jpg",
                            Name = "Smart Phone",
                            Price = 2000m,
                            Status = 1,
                            StockQuantity = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
<<<<<<<< HEAD:ETicaretPlatformu.InfraStructure/Migrations/20240406213719_initial.Designer.cs
                            CreateDate = new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2883),
========
                            CreateDate = new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(563),
>>>>>>>> origin/master:ETicaretPlatformu.InfraStructure/Migrations/20240409173208_init.Designer.cs
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
<<<<<<<< HEAD:ETicaretPlatformu.InfraStructure/Migrations/20240406213719_initial.Designer.cs
                            CreateDate = new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2884),
========
                            CreateDate = new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(568),
>>>>>>>> origin/master:ETicaretPlatformu.InfraStructure/Migrations/20240409173208_init.Designer.cs
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
<<<<<<<< HEAD:ETicaretPlatformu.InfraStructure/Migrations/20240406213719_initial.Designer.cs
                            CreateDate = new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2886),
========
                            CreateDate = new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(573),
>>>>>>>> origin/master:ETicaretPlatformu.InfraStructure/Migrations/20240409173208_init.Designer.cs
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
<<<<<<<< HEAD:ETicaretPlatformu.InfraStructure/Migrations/20240406213719_initial.Designer.cs
                            CreateDate = new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2887),
========
                            CreateDate = new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(578),
>>>>>>>> origin/master:ETicaretPlatformu.InfraStructure/Migrations/20240409173208_init.Designer.cs
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
<<<<<<<< HEAD:ETicaretPlatformu.InfraStructure/Migrations/20240406213719_initial.Designer.cs
                            CreateDate = new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2889),
========
                            CreateDate = new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(587),
>>>>>>>> origin/master:ETicaretPlatformu.InfraStructure/Migrations/20240409173208_init.Designer.cs
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
<<<<<<<< HEAD:ETicaretPlatformu.InfraStructure/Migrations/20240406213719_initial.Designer.cs
                            CreateDate = new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2890),
========
                            CreateDate = new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(592),
>>>>>>>> origin/master:ETicaretPlatformu.InfraStructure/Migrations/20240409173208_init.Designer.cs
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
<<<<<<<< HEAD:ETicaretPlatformu.InfraStructure/Migrations/20240406213719_initial.Designer.cs
                            CreateDate = new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2892),
========
                            CreateDate = new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(597),
>>>>>>>> origin/master:ETicaretPlatformu.InfraStructure/Migrations/20240409173208_init.Designer.cs
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
<<<<<<<< HEAD:ETicaretPlatformu.InfraStructure/Migrations/20240406213719_initial.Designer.cs
                            CreateDate = new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2893),
========
                            CreateDate = new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(602),
>>>>>>>> origin/master:ETicaretPlatformu.InfraStructure/Migrations/20240409173208_init.Designer.cs
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
<<<<<<<< HEAD:ETicaretPlatformu.InfraStructure/Migrations/20240406213719_initial.Designer.cs
                            CreateDate = new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2895),
========
                            CreateDate = new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(610),
>>>>>>>> origin/master:ETicaretPlatformu.InfraStructure/Migrations/20240409173208_init.Designer.cs
                            Description = "2-Person Camping Tent",
                            ImagePath = "/images/ProductImages/CampingTent.jpg",
                            Name = "Camping Tent",
                            Price = 150m,
                            Status = 1,
                            StockQuantity = 100
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
<<<<<<<< HEAD:ETicaretPlatformu.InfraStructure/Migrations/20240406213719_initial.Designer.cs
                            ConcurrencyStamp = "f7e8ada4-5be1-46c0-b5b3-e4b9af4e9100",
                            CreateDate = new DateTime(2024, 4, 7, 0, 37, 18, 690, DateTimeKind.Local).AddTicks(4018),
========
                            ConcurrencyStamp = "bc7987aa-c391-4a83-bb13-7abf852fcff0",
                            CreateDate = new DateTime(2024, 4, 9, 20, 32, 7, 725, DateTimeKind.Local).AddTicks(9239),
>>>>>>>> origin/master:ETicaretPlatformu.InfraStructure/Migrations/20240409173208_init.Designer.cs
                            Email = "admin@example.com",
                            EmailConfirmed = true,
                            FirstName = "admin",
                            ImagePath = "/images/01-admin.jpg",
                            LastName = "admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN",
<<<<<<<< HEAD:ETicaretPlatformu.InfraStructure/Migrations/20240406213719_initial.Designer.cs
                            PasswordHash = "AQAAAAEAACcQAAAAEDQ/NmxE2UYyCfXOJSqRI3h4MQGvutLOuNl41Ki1Iiex9DT8LYrnYd2hEi6s3Fi6xA==",
                            PaymentMethod = 0,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6e5cc54b-4d82-4346-9d82-8e6e361e1d91",
========
                            PasswordHash = "AQAAAAEAACcQAAAAEPTNuV1ZhCFinP64cKIlwScAd1uYtSdpQHREzfdmzJjJC2b42N234vKqYi6mdJ+2qQ==",
                            PaymentMethod = 0,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "962e1e45-05e0-4edd-b918-a51e087dac8f",
>>>>>>>> origin/master:ETicaretPlatformu.InfraStructure/Migrations/20240409173208_init.Designer.cs
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
