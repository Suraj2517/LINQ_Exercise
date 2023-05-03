using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Exercise
{
    class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        static void SeedData(List<Product> product)
        {
            product.Add(new Product { ProductId = "P001", ProductName = "Laptop", Brand = "Dell", Quantity = 5, Price = 35000 });
            product.Add(new Product { ProductId = "P002", ProductName = "Camera", Brand = "Canon", Quantity = 8, Price = 28500 });
            product.Add(new Product { ProductId = "P003", ProductName = "Tablet", Brand = "Lenovo", Quantity = 4, Price = 15000 });
            product.Add(new Product { ProductId = "P004", ProductName = "Mobile", Brand = "Apple", Quantity = 9, Price = 65000 });
            product.Add(new Product { ProductId = "P005", ProductName = "Earphones", Brand = "Boat", Quantity = 2, Price = 1500 });
        }
        class Program
        {
            static void Main(string[] args)
            {
                List<Product> product = new List<Product>();
                SeedData(product);

                var productNames = from products in product where products.Price >= 20000 && products.Price <= 40000 select products.ProductName;

                Console.WriteLine("Product Names where Price is between 20000 to 40000:");
                foreach (var productName in productNames)
                {
                    Console.WriteLine(productName);
                }

                var productData = from products in product where products.ProductName.Contains("a") select products;

                Console.WriteLine("\nData where ProductName contains letter a:");
                foreach (var products in productData)
                {
                    Console.WriteLine(product.ToString());
                }

                var sortedData = from products in product orderby products.ProductName select products;

                Console.WriteLine("\nAll data arranged in alphabetical order based on ProductName:");
                foreach (var products in sortedData)
                {
                    Console.WriteLine(product.ToString());
                }

                var highestPrice = product.Max(product => product.Price);
                Console.WriteLine("\nHighest Price from Product List: " + highestPrice);

                var productExists = product.Any(product => product.ProductId == "P003");
                Console.WriteLine("\nDoes the Product with ProductId P003 exist in Product List? \n" + productExists);
            }
        }
    }
}