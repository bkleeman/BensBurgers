using System.Collections.Generic;
using System.Data.Entity;

namespace BensBurgers.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Entrees"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Sides"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Drinks"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Desserts"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "The Classic",
                    Description = "Lettuce, tomatoes, onion, pickles, ketchup, mustard.",
                    ImagePath="theclassic.jpg",
                    UnitPrice = 5.99,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Patty Melt",
                    Description = "Standard patty melt on wheat or white toast. Bacon optional.",
                    ImagePath="pattymelt.jpg",
                    UnitPrice = 4.49,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "BLT",
                    Description = "A picnic table classic.",
                    ImagePath="blt.jpg",
                    UnitPrice = 5.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Steakburger",
                    Description = "Chargrilled all-beef mouth watering burger. Combine with a shake for best results.",
                    ImagePath="steakburger.jpg",
                    UnitPrice = 6.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "The Impossible Burger",
                    Description = "It'll make you swear off meat for life!",
                    ImagePath="impossibleburger.jpg",
                    UnitPrice = 9.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "French Fries",
                    Description = "Belongs right next to any of our entrees, easily.",
                    ImagePath="frenchfries.jpg",
                    UnitPrice = 2.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Onion Rings",
                    Description = "Enjoy a mountain of these if you're feeling like a challenge.",
                    ImagePath="onionrings.jpg",
                    UnitPrice = 4.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Nachos",
                    Description = "Grab a plate to share or eat solo.",
                    ImagePath="nachos.jpg",
                    UnitPrice = 7.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Potato Wedges",
                    Description = "A house favorite.",
                    ImagePath="potatowedges.jpg",
                    UnitPrice = 4.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Milkshake",
                    Description = "Strawberry, vanilla & honey, chocolate, or PB&J.",
                    ImagePath="milkshake.jpg",
                    UnitPrice = 4.99,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Iced Tea",
                    Description = "Ask for sweet or unsweet.",
                    ImagePath="icedtea.jpg",
                    UnitPrice = 1.99,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Damn Good Coffee",
                    Description = "Agent Cooper's Favorite.",
                    ImagePath="coffee.jpg",
                    UnitPrice = 1.99,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Tiramisu",
                    Description = "What more could you really want?",
                    ImagePath="tiramisu.jpg",
                    UnitPrice = 4.99,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Cheesecake",
                    Description = "Ask for fresh fruit or chocolate turtle.",
                    ImagePath="cheesecake.jpg",
                    UnitPrice = 4.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Cherry Pie",
                    Description = "Goes well with our Damn Good Coffee.",
                    ImagePath="cherrypie.jpg",
                    UnitPrice = 2.99,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Carrot Cake",
                    Description = "You can just pretend it's healthy.",
                    ImagePath="carrotcake.jpg",
                    UnitPrice = 3.99,
                    CategoryID = 4
                }
            };

            return products;
        }
    }
}