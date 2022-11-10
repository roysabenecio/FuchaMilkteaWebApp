﻿// <auto-generated />
using System;
using Fucha.DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fucha.DataLayer.Migrations
{
    [DbContext(typeof(FuchaMilkteaContext))]
    [Migration("20221110082034_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Fucha.DomainClasses.AddOn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("AddOnPrice")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AddOns");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddOnPrice = 10.0,
                            Name = "Pearl"
                        },
                        new
                        {
                            Id = 2,
                            AddOnPrice = 10.0,
                            Name = "Nata"
                        },
                        new
                        {
                            Id = 3,
                            AddOnPrice = 10.0,
                            Name = "Nutella"
                        },
                        new
                        {
                            Id = 4,
                            AddOnPrice = 10.0,
                            Name = "Cookies"
                        },
                        new
                        {
                            Id = 5,
                            AddOnPrice = 10.0,
                            Name = "Cream Cheese"
                        });
                });

            modelBuilder.Entity("Fucha.DomainClasses.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("IngredientCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IngredientStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeasurementType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Ingredient");
                });

            modelBuilder.Entity("Fucha.DomainClasses.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ItemCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeasurementUnit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ItemCategory = "Milk Tea Powder",
                            MeasurementUnit = "Kilograms",
                            Name = "Okinawa Powder",
                            Quantity = 5.0
                        },
                        new
                        {
                            Id = 2,
                            ItemCategory = "Utensil",
                            MeasurementUnit = "Pieces",
                            Name = "Milk Tea Cup",
                            Quantity = 10.0
                        });
                });

            modelBuilder.Entity("Fucha.DomainClasses.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MenuCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MenuCategoryId = 1,
                            Name = "Okinawa"
                        },
                        new
                        {
                            Id = 2,
                            MenuCategoryId = 1,
                            Name = "Red Velvet"
                        },
                        new
                        {
                            Id = 3,
                            MenuCategoryId = 1,
                            Name = "Wintermelon"
                        },
                        new
                        {
                            Id = 4,
                            MenuCategoryId = 1,
                            Name = "Salted Caramel"
                        },
                        new
                        {
                            Id = 5,
                            MenuCategoryId = 1,
                            Name = "Taro"
                        },
                        new
                        {
                            Id = 6,
                            MenuCategoryId = 2,
                            Name = "Cookies & Cream"
                        },
                        new
                        {
                            Id = 7,
                            MenuCategoryId = 2,
                            Name = "Dark Chocolate"
                        },
                        new
                        {
                            Id = 8,
                            MenuCategoryId = 2,
                            Name = "Hokkaido"
                        },
                        new
                        {
                            Id = 9,
                            MenuCategoryId = 2,
                            Name = "Black Wintermel"
                        },
                        new
                        {
                            Id = 10,
                            MenuCategoryId = 2,
                            Name = "Avocado Cheescake"
                        },
                        new
                        {
                            Id = 11,
                            MenuCategoryId = 2,
                            Name = "Choco Bunny"
                        },
                        new
                        {
                            Id = 12,
                            MenuCategoryId = 2,
                            Name = "Choco Berry Meiji"
                        },
                        new
                        {
                            Id = 13,
                            MenuCategoryId = 2,
                            Name = "Mango Graham Cabin"
                        },
                        new
                        {
                            Id = 14,
                            MenuCategoryId = 2,
                            Name = "Salty Cream Okinawa"
                        },
                        new
                        {
                            Id = 15,
                            MenuCategoryId = 3,
                            Name = "Japanese Sausage with Rice & Egg"
                        },
                        new
                        {
                            Id = 16,
                            MenuCategoryId = 3,
                            Name = "Hungarian Sausage with Rice & Egg"
                        },
                        new
                        {
                            Id = 17,
                            MenuCategoryId = 3,
                            Name = "Spam Bacon with Rice & Egg"
                        },
                        new
                        {
                            Id = 18,
                            MenuCategoryId = 3,
                            Name = "Cheesedog with Rice & Hotdog"
                        },
                        new
                        {
                            Id = 19,
                            MenuCategoryId = 3,
                            Name = "Hungarian Sausage"
                        },
                        new
                        {
                            Id = 20,
                            MenuCategoryId = 3,
                            Name = "Spam & Japanese Sausage"
                        });
                });

            modelBuilder.Entity("Fucha.DomainClasses.MenuCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MenuCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Classic Milk Tea"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Premium Milk Tea"
                        },
                        new
                        {
                            Id = 3,
                            Name = "All Day Meals"
                        });
                });

            modelBuilder.Entity("Fucha.DomainClasses.MenuPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MenuCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("MenuId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("SizeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MenuPrices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MenuCategoryId = 1,
                            Price = 50.0,
                            SizeId = 1
                        },
                        new
                        {
                            Id = 2,
                            MenuCategoryId = 1,
                            Price = 60.0,
                            SizeId = 2
                        },
                        new
                        {
                            Id = 3,
                            MenuCategoryId = 1,
                            Price = 70.0,
                            SizeId = 3
                        },
                        new
                        {
                            Id = 4,
                            MenuCategoryId = 1,
                            Price = 120.0,
                            SizeId = 4
                        },
                        new
                        {
                            Id = 5,
                            MenuCategoryId = 2,
                            Price = 70.0,
                            SizeId = 2
                        },
                        new
                        {
                            Id = 6,
                            MenuCategoryId = 2,
                            Price = 90.0,
                            SizeId = 3
                        },
                        new
                        {
                            Id = 7,
                            MenuCategoryId = 2,
                            Price = 130.0,
                            SizeId = 4
                        },
                        new
                        {
                            Id = 8,
                            MenuCategoryId = 3,
                            MenuId = 15,
                            Price = 60.0
                        },
                        new
                        {
                            Id = 9,
                            MenuCategoryId = 3,
                            MenuId = 16,
                            Price = 75.0
                        },
                        new
                        {
                            Id = 10,
                            MenuCategoryId = 3,
                            MenuId = 17,
                            Price = 65.0
                        },
                        new
                        {
                            Id = 11,
                            MenuCategoryId = 3,
                            MenuId = 18,
                            Price = 65.0
                        },
                        new
                        {
                            Id = 12,
                            MenuCategoryId = 3,
                            MenuId = 19,
                            Price = 50.0
                        },
                        new
                        {
                            Id = 13,
                            MenuCategoryId = 3,
                            MenuId = 20,
                            Price = 65.0
                        });
                });

            modelBuilder.Entity("Fucha.DomainClasses.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AddOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("AddOnPrice")
                        .HasColumnType("float");

                    b.Property<int>("MenuCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OrderPrice")
                        .HasColumnType("float");

                    b.Property<int>("OrderQuantity")
                        .HasColumnType("int");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SizeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Fucha.DomainClasses.PurchaseRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("PurchaseRecords");
                });

            modelBuilder.Entity("Fucha.DomainClasses.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("RecipeCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId")
                        .IsUnique();

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Fucha.DomainClasses.SaleTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DateSold")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("SalesTransaction");
                });

            modelBuilder.Entity("Fucha.DomainClasses.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Small"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Medium"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Large"
                        },
                        new
                        {
                            Id = 4,
                            Name = "1 Liter"
                        });
                });

            modelBuilder.Entity("Fucha.DomainClasses.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DateCreated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Roy",
                            LastName = "Sabenecio",
                            Password = "r",
                            Role = "Admin",
                            UserName = "r",
                            UserStatus = "Approved"
                        });
                });

            modelBuilder.Entity("Fucha.DomainClasses.PurchaseRecord", b =>
                {
                    b.HasOne("Fucha.DomainClasses.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Fucha.DomainClasses.Recipe", b =>
                {
                    b.HasOne("Fucha.DomainClasses.Ingredient", "Ingredient")
                        .WithOne("Recipe")
                        .HasForeignKey("Fucha.DomainClasses.Recipe", "IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("Fucha.DomainClasses.Ingredient", b =>
                {
                    b.Navigation("Recipe");
                });
#pragma warning restore 612, 618
        }
    }
}
