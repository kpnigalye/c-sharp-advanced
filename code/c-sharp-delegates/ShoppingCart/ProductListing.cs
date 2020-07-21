using System;
using System.Collections.Generic;

namespace c_sharp_delegates
{
    public class ProductListing
    {
        public static List<Product> Products { get; set; } = new List<Product>();

        static ProductListing()
        {
            Products.Add(new Product { Name = "Smart TV", Code = 101, Price = 45000 });
            Products.Add(new Product { Name = "LED TV", Code = 102, Price = 30000 });
            Products.Add(new Product { Name = "Chromecast", Code = 103, Price = 5000 });
        }

        public static void GetProducts()
        {
            foreach(var item in Products)
            {
                Console.WriteLine($"=> {item.Code}: {item.Name} \n\tPrice: Rs.{item.Price}");
            }
            Console.WriteLine("\n--------------------------------");
        }
    }
}
