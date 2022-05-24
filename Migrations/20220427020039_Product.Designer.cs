﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Team2.Models;

namespace Team2.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20220427020039_Product")]
    partial class Product
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Team2.Models.CartItem", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CartID");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("Team2.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            ProductDescription = "Our classic burger. A mouth-watering, tasty half-pound hamburger with all the fixin's.",
                            ProductName = "Half-Pound Burger",
                            ProductPhoto = "halfpoundburger.jpg",
                            ProductPrice = 7.99m,
                            ProductType = "Entree"
                        },
                        new
                        {
                            ProductID = 2,
                            ProductDescription = "Still our classic burger, just a little smaller. Same great taste, smaller footprint.",
                            ProductName = "Third-Pound Burger",
                            ProductPhoto = "thirdpoundburger.jpg",
                            ProductPrice = 6.99m,
                            ProductType = "Entree"
                        },
                        new
                        {
                            ProductID = 3,
                            ProductDescription = "Our best burger in the smallest package. Perfect for those that 'aren't hungry.'",
                            ProductName = "Quarter-Pound Burger",
                            ProductPhoto = "quarterpoundburger.jpg",
                            ProductPrice = 4.99m,
                            ProductType = "Entree"
                        },
                        new
                        {
                            ProductID = 4,
                            ProductDescription = "Yes, we also entered the race for the best chicken sandiwch. And doggone it, we won.",
                            ProductName = "Fried Chicken Sandwich",
                            ProductPhoto = "friedchickensandwich.jpg",
                            ProductPrice = 7.99m,
                            ProductType = "Entree"
                        },
                        new
                        {
                            ProductID = 5,
                            ProductDescription = "For those that are on a diet, but were the first to suggest coming to eat here.",
                            ProductName = "Grilled Chicken Sandwich",
                            ProductPhoto = "grilledchickensandwich.jpg",
                            ProductPrice = 6.99m,
                            ProductType = "Entree"
                        },
                        new
                        {
                            ProductID = 6,
                            ProductDescription = "Fresh, hot, hand-breaded, fried chicken tenders. Need we say more?",
                            ProductName = "Chicken Tenders",
                            ProductPhoto = "chickentenders.jpg",
                            ProductPrice = 4.99m,
                            ProductType = "Entree"
                        },
                        new
                        {
                            ProductID = 7,
                            ProductDescription = "Golden, lightly-salted potato wedges. You know you want them.",
                            ProductName = "Large French Fries",
                            ProductPhoto = "largefries.jpg",
                            ProductPrice = 4.99m,
                            ProductType = "Side"
                        },
                        new
                        {
                            ProductID = 8,
                            ProductDescription = "Large size too unhealthy for you? Feel better by only ordering a medium.",
                            ProductName = "Medium French Fries",
                            ProductPhoto = "largefries.jpg",
                            ProductPrice = 3.99m,
                            ProductType = "Side"
                        },
                        new
                        {
                            ProductID = 9,
                            ProductDescription = "Sometimes, you just gotta have some good ol' french fries, even if it's not a lot.",
                            ProductName = "Small French Fries",
                            ProductPhoto = "largefries.jpg",
                            ProductPrice = 2.99m,
                            ProductType = "Side"
                        },
                        new
                        {
                            ProductID = 10,
                            ProductDescription = "Who can possibly resist the allure of chocolate chip cookies, fresh out of the oven? Not you!",
                            ProductName = "Chocolate Chip Cookie",
                            ProductPhoto = "chocolatechipcookie.jpg",
                            ProductPrice = 0.99m,
                            ProductType = "Side"
                        },
                        new
                        {
                            ProductID = 11,
                            ProductDescription = "Sometimes, you just want something plain and simple. Hard to go wrong with a classic cookie.",
                            ProductName = "Sugar Cookie",
                            ProductPhoto = "sugarcookie.jpg",
                            ProductPrice = 0.99m,
                            ProductType = "Side"
                        },
                        new
                        {
                            ProductID = 12,
                            ProductDescription = "A warm peanut butter cookie, just like grandma used to make.",
                            ProductName = "Peanut Butter Cookie",
                            ProductPhoto = "peanutbuttercookie.jpg",
                            ProductPrice = 0.99m,
                            ProductType = "Side"
                        },
                        new
                        {
                            ProductID = 13,
                            ProductDescription = "How do you best wash down a tasty meal? With a large fountain drink, of course!",
                            ProductName = "Large Fountain Drink",
                            ProductPhoto = "largedrink.jpg",
                            ProductPrice = 2.99m,
                            ProductType = "Drink"
                        },
                        new
                        {
                            ProductID = 14,
                            ProductDescription = "Okay, maybe the large fountain drink is more than you need. No worries, just grab a medium!",
                            ProductName = "Medium Fountain Drink",
                            ProductPhoto = "largedrink.jpg",
                            ProductPrice = 1.99m,
                            ProductType = "Drink"
                        },
                        new
                        {
                            ProductID = 15,
                            ProductDescription = "Need a quick pick-me-up? Grab a small fountain drink!",
                            ProductName = "Small Fountain Drink",
                            ProductPhoto = "largedrink.jpg",
                            ProductPrice = 0.99m,
                            ProductType = "Drink"
                        },
                        new
                        {
                            ProductID = 16,
                            ProductDescription = "The unofficial official drink of Texans (other than Dr Pepper, of course.)",
                            ProductName = "Sweet Tea",
                            ProductPhoto = "sweettea.jpg",
                            ProductPrice = 1.99m,
                            ProductType = "Drink"
                        },
                        new
                        {
                            ProductID = 17,
                            ProductDescription = "An all-time classic drink. Perfect for a hot summer day. And all other days, too.",
                            ProductName = "Lemonade",
                            ProductPhoto = "lemonade.jpg",
                            ProductPrice = 1.99m,
                            ProductType = "Drink"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
