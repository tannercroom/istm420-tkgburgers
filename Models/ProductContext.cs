using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Team2.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> Cart { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductID = 1,
                    ProductName = "Half-Pound Burger",
                    ProductPhoto = "halfpoundburger.jpg",
                    ProductDescription = "Our classic burger. A mouth-watering, tasty half-pound hamburger with all the fixin's.",
                    ProductType = "Entree",
                    ProductPrice = 7.99m
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Third-Pound Burger",
                    ProductPhoto = "thirdpoundburger.jpg",
                    ProductDescription = "Still our classic burger, just a little smaller. Same great taste, smaller footprint.",
                    ProductType = "Entree",
                    ProductPrice = 6.99m
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Quarter-Pound Burger",
                    ProductPhoto = "quarterpoundburger.jpg",
                    ProductDescription = "Our best burger in the smallest package. Perfect for those that 'aren't hungry.'",
                    ProductType = "Entree",
                    ProductPrice = 4.99m
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Fried Chicken Sandwich",
                    ProductPhoto = "friedchickensandwich.jpg",
                    ProductDescription = "Yes, we also entered the race for the best chicken sandiwch. And doggone it, we won.",
                    ProductType = "Entree",
                    ProductPrice = 7.99m
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Grilled Chicken Sandwich",
                    ProductPhoto = "grilledchickensandwich.jpg",
                    ProductDescription = "For those that are on a diet, but were the first to suggest coming to eat here.",
                    ProductType = "Entree",
                    ProductPrice = 6.99m
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Chicken Tenders",
                    ProductPhoto = "chickentenders.jpg",
                    ProductDescription = "Fresh, hot, hand-breaded, fried chicken tenders. Need we say more?",
                    ProductType = "Entree",
                    ProductPrice = 4.99m
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Large French Fries",
                    ProductPhoto = "largefries.jpg",
                    ProductDescription = "Golden, lightly-salted potato wedges. You know you want them.",
                    ProductType = "Side",
                    ProductPrice = 4.99m
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Medium French Fries",
                    ProductPhoto = "largefries.jpg",
                    ProductDescription = "Large size too unhealthy for you? Feel better by only ordering a medium.",
                    ProductType = "Side",
                    ProductPrice = 3.99m
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Small French Fries",
                    ProductPhoto = "largefries.jpg",
                    ProductDescription = "Sometimes, you just gotta have some good ol' french fries, even if it's not a lot.",
                    ProductType = "Side",
                    ProductPrice = 2.99m
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Chocolate Chip Cookie",
                    ProductPhoto = "chocolatechipcookie.jpg",
                    ProductDescription = "Who can possibly resist the allure of chocolate chip cookies, fresh out of the oven? Not you!",
                    ProductType = "Side",
                    ProductPrice = 0.99m
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Sugar Cookie",
                    ProductPhoto = "sugarcookie.jpg",
                    ProductDescription = "Sometimes, you just want something plain and simple. Hard to go wrong with a classic cookie.",
                    ProductType = "Side",
                    ProductPrice = 0.99m
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Peanut Butter Cookie",
                    ProductPhoto = "peanutbuttercookie.jpg",
                    ProductDescription = "A warm peanut butter cookie, just like grandma used to make.",
                    ProductType = "Side",
                    ProductPrice = 0.99m
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Large Fountain Drink",
                    ProductPhoto = "largedrink.jpg",
                    ProductDescription = "How do you best wash down a tasty meal? With a large fountain drink, of course!",
                    ProductType = "Drink",
                    ProductPrice = 2.99m
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Medium Fountain Drink",
                    ProductPhoto = "largedrink.jpg",
                    ProductDescription = "Okay, maybe the large fountain drink is more than you need. No worries, just grab a medium!",
                    ProductType = "Drink",
                    ProductPrice = 1.99m
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Small Fountain Drink",
                    ProductPhoto = "largedrink.jpg",
                    ProductDescription = "Need a quick pick-me-up? Grab a small fountain drink!",
                    ProductType = "Drink",
                    ProductPrice = 0.99m
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Sweet Tea",
                    ProductPhoto = "sweettea.jpg",
                    ProductDescription = "The unofficial official drink of Texans (other than Dr Pepper, of course.)",
                    ProductType = "Drink",
                    ProductPrice = 1.99m

                },
                new Product
                {
                    ProductID = 17,
                    ProductName = "Lemonade",
                    ProductPhoto = "lemonade.jpg",
                    ProductDescription = "An all-time classic drink. Perfect for a hot summer day. And all other days, too.",
                    ProductType = "Drink",
                    ProductPrice = 1.99m
                }
                );
        }
    }
}
