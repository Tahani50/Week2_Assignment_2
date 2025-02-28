using Microsoft.AspNetCore.Mvc;
using AmazonOrderSystem.Models;
using System.Collections.Generic;

    // Populate product dummy data into Model.
public class ProductController : Controller
{
    public static List<Product> products = new List<Product>
    {               
        new Product {ProductID = 1, Name = "Laptop", Category = "Electronics", Price = 1000.0M, StockQuantity = 6},
        new Product {ProductID = 2, Name = "Necklace", Category = "Jewelry", Price = 30.0M, StockQuantity = 40},
        new Product {ProductID = 3, Name = "Smartphone", Category = "Electronics", Price = 8000.0M, StockQuantity = 9},
        new Product {ProductID = 4, Name = "Lip Stick", Category = "Beauty", Price = 8.0M, StockQuantity = 90},
        new Product {ProductID = 5, Name = "Tablet", Category = "Electronics", Price = 2000.0M, StockQuantity = 4},
        new Product {ProductID = 6, Name = "Headphones", Category = "Electronics", Price = 150.0M, StockQuantity = 20},
        new Product {ProductID = 7, Name = "Wrist Watch", Category = "Jewelry", Price = 250.0M, StockQuantity = 30},
        new Product {ProductID = 8, Name = "Foundation", Category = "Beauty", Price = 15.0M, StockQuantity = 100},
        new Product {ProductID = 9, Name = "Gaming Console", Category = "Electronics", Price = 500.0M, StockQuantity = 10},
        new Product {ProductID = 10, Name = "Handbag", Category = "Fashion", Price = 80.0M, StockQuantity = 25},
        new Product {ProductID = 11, Name = "Smart TV", Category = "Electronics", Price = 1200.0M, StockQuantity = 5},
        new Product {ProductID = 12, Name = "Sunglasses", Category = "Fashion", Price = 60.0M, StockQuantity = 15},
        new Product {ProductID = 13, Name = "Perfume", Category = "Beauty", Price = 55.0M, StockQuantity = 50},
        new Product {ProductID = 14, Name = "Bluetooth Speaker", Category = "Electronics", Price = 75.0M, StockQuantity = 18},
        new Product {ProductID = 15, Name = "Earrings", Category = "Jewelry", Price = 40.0M, StockQuantity = 60},
        new Product {ProductID = 16, Name = "Hair Straightener", Category = "Beauty", Price = 45.0M, StockQuantity = 25},
        new Product {ProductID = 17, Name = "Winter Jacket", Category = "Fashion", Price = 120.0M, StockQuantity = 10},
        new Product {ProductID = 18, Name = "Backpack", Category = "Fashion", Price = 55.0M, StockQuantity = 35},
        new Product {ProductID = 19, Name = "Wireless Mouse", Category = "Electronics", Price = 25.0M, StockQuantity = 40},
        new Product {ProductID = 20, Name = "External Hard Drive", Category = "Electronics", Price = 90.0M, StockQuantity = 12},
        new Product {ProductID = 21, Name = "Keyboard", Category = "Electronics", Price = 45.0M, StockQuantity = 20},
        new Product {ProductID = 22, Name = "Fitness Tracker", Category = "Electronics", Price = 150.0M, StockQuantity = 15},
        new Product {ProductID = 23, Name = "Face Cream", Category = "Beauty", Price = 30.0M, StockQuantity = 80},
        new Product {ProductID = 24, Name = "Sofa Set", Category = "Furniture", Price = 850.0M, StockQuantity = 5},
        new Product {ProductID = 25, Name = "Dining Table", Category = "Furniture", Price = 600.0M, StockQuantity = 3},
        new Product {ProductID = 26, Name = "Office Chair", Category = "Furniture", Price = 200.0M, StockQuantity = 8},
        new Product {ProductID = 27, Name = "Microwave", Category = "Home Appliances", Price = 180.0M, StockQuantity = 7},
        new Product {ProductID = 28, Name = "Refrigerator", Category = "Home Appliances", Price = 1000.0M, StockQuantity = 4},
        new Product {ProductID = 29, Name = "Washing Machine", Category = "Home Appliances", Price = 850.0M, StockQuantity = 5},
        new Product {ProductID = 30, Name = "Electric Kettle", Category = "Home Appliances", Price = 40.0M, StockQuantity = 20},
        new Product {ProductID = 31, Name = "Gaming Chair", Category = "Furniture", Price = 250.0M, StockQuantity = 6},
        new Product {ProductID = 32, Name = "Smartwatch", Category = "Electronics", Price = 299.0M, StockQuantity = 14},
        new Product {ProductID = 33, Name = "Running Shoes", Category = "Fashion", Price = 120.0M, StockQuantity = 25},
        new Product {ProductID = 34, Name = "Men's Leather Belt", Category = "Fashion", Price = 35.0M, StockQuantity = 50},
        new Product {ProductID = 35, Name = "LED Desk Lamp", Category = "Home Decor", Price = 65.0M, StockQuantity = 15},
        new Product {ProductID = 36, Name = "Throw Pillow", Category = "Home Decor", Price = 20.0M, StockQuantity = 40},
        new Product {ProductID = 37, Name = "Men's Suit", Category = "Fashion", Price = 350.0M, StockQuantity = 7},
        new Product {ProductID = 38, Name = "Yoga Mat", Category = "Fitness", Price = 25.0M, StockQuantity = 30},
        new Product {ProductID = 39, Name = "Protein Powder", Category = "Health", Price = 50.0M, StockQuantity = 25},
        new Product {ProductID = 40, Name = "Electric Toothbrush", Category = "Health", Price = 80.0M, StockQuantity = 15},
        new Product {ProductID = 41, Name = "Bookshelf", Category = "Furniture", Price = 175.0M, StockQuantity = 6},
        new Product {ProductID = 42, Name = "Makeup Kit", Category = "Beauty", Price = 90.0M, StockQuantity = 25},
        new Product {ProductID = 43, Name = "VR Headset", Category = "Electronics", Price = 350.0M, StockQuantity = 10},
        new Product {ProductID = 44, Name = "Treadmill", Category = "Fitness", Price = 1200.0M, StockQuantity = 3},
        new Product {ProductID = 45, Name = "Hair Dryer", Category = "Beauty", Price = 50.0M, StockQuantity = 30},
        new Product {ProductID = 46, Name = "Wall Clock", Category = "Home Decor", Price = 45.0M, StockQuantity = 20},
        new Product {ProductID = 47, Name = "Cookware Set", Category = "Kitchen", Price = 200.0M, StockQuantity = 10},
        new Product {ProductID = 48, Name = "Coffee Maker", Category = "Kitchen", Price = 180.0M, StockQuantity = 5},
        new Product {ProductID = 49, Name = "Smart Door Lock", Category = "Home Security", Price = 220.0M, StockQuantity = 8},
        new Product {ProductID = 50, Name = "Dumbbell Set", Category = "Fitness", Price = 75.0M, StockQuantity = 15}
    };

    [HttpGet("/Products")]
    public IActionResult Index()
    {
        return View(products);
    }
}
