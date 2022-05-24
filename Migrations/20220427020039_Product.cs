using Microsoft.EntityFrameworkCore.Migrations;

namespace Team2.Migrations
{
    public partial class Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    CartID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    ProductPhoto = table.Column<string>(nullable: true),
                    ProductPrice = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.CartID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    ProductPhoto = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ProductPrice = table.Column<decimal>(nullable: false),
                    ProductType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "ProductDescription", "ProductName", "ProductPhoto", "ProductPrice", "ProductType" },
                values: new object[,]
                {
                    { 1, "Our classic burger. A mouth-watering, tasty half-pound hamburger with all the fixin's.", "Half-Pound Burger", "halfpoundburger.jpg", 7.99m, "Entree" },
                    { 15, "Need a quick pick-me-up? Grab a small fountain drink!", "Small Fountain Drink", "largedrink.jpg", 0.99m, "Drink" },
                    { 14, "Okay, maybe the large fountain drink is more than you need. No worries, just grab a medium!", "Medium Fountain Drink", "largedrink.jpg", 1.99m, "Drink" },
                    { 13, "How do you best wash down a tasty meal? With a large fountain drink, of course!", "Large Fountain Drink", "largedrink.jpg", 2.99m, "Drink" },
                    { 12, "A warm peanut butter cookie, just like grandma used to make.", "Peanut Butter Cookie", "peanutbuttercookie.jpg", 0.99m, "Side" },
                    { 11, "Sometimes, you just want something plain and simple. Hard to go wrong with a classic cookie.", "Sugar Cookie", "sugarcookie.jpg", 0.99m, "Side" },
                    { 10, "Who can possibly resist the allure of chocolate chip cookies, fresh out of the oven? Not you!", "Chocolate Chip Cookie", "chocolatechipcookie.jpg", 0.99m, "Side" },
                    { 16, "The unofficial official drink of Texans (other than Dr Pepper, of course.)", "Sweet Tea", "sweettea.jpg", 1.99m, "Drink" },
                    { 9, "Sometimes, you just gotta have some good ol' french fries, even if it's not a lot.", "Small French Fries", "largefries.jpg", 2.99m, "Side" },
                    { 7, "Golden, lightly-salted potato wedges. You know you want them.", "Large French Fries", "largefries.jpg", 4.99m, "Side" },
                    { 6, "Fresh, hot, hand-breaded, fried chicken tenders. Need we say more?", "Chicken Tenders", "chickentenders.jpg", 4.99m, "Entree" },
                    { 5, "For those that are on a diet, but were the first to suggest coming to eat here.", "Grilled Chicken Sandwich", "grilledchickensandwich.jpg", 6.99m, "Entree" },
                    { 4, "Yes, we also entered the race for the best chicken sandiwch. And doggone it, we won.", "Fried Chicken Sandwich", "friedchickensandwich.jpg", 7.99m, "Entree" },
                    { 3, "Our best burger in the smallest package. Perfect for those that 'aren't hungry.'", "Quarter-Pound Burger", "quarterpoundburger.jpg", 4.99m, "Entree" },
                    { 2, "Still our classic burger, just a little smaller. Same great taste, smaller footprint.", "Third-Pound Burger", "thirdpoundburger.jpg", 6.99m, "Entree" },
                    { 8, "Large size too unhealthy for you? Feel better by only ordering a medium.", "Medium French Fries", "largefries.jpg", 3.99m, "Side" },
                    { 17, "An all-time classic drink. Perfect for a hot summer day. And all other days, too.", "Lemonade", "lemonade.jpg", 1.99m, "Drink" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
