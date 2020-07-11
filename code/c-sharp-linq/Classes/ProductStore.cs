using System;
using System.Collections.Generic;

namespace c_sharp_linq
{
    /// <summary>
    /// Class to populate temp data
    /// </summary>
    public static class ProductStore
    {
        public static IEnumerable<string> GetProductTypes()
        {
            return new string[]
            {
                "Electronics",
                "Books",
                "Beuty Products",
                "Fitness",
                "Support",
                "Software",
                "Furniture"
            };
        }

        public static IEnumerable<Product> GetProducts()
        {
            return new Product[]
            {
                new Product { Name = "TV", ProductType = "Electronics" },
                new Product { Name = "Laptop", ProductType = "Electronics" },
                new Product { Name = "E-book", ProductType = "Books" },
                new Product { Name = "Hardcopy", ProductType = "Books" },
                new Product { Name = "Kindle Book", ProductType = "Books" },
                new Product { Name = "Fairness Cream", ProductType = "Beuty Products" },
                new Product { Name = "Grooming Kit", ProductType = "Beuty Products" },
                new Product { Name = "Skin Care", ProductType = "Beuty Products" },
                new Product { Name = "Fragrances", ProductType = "Beuty Products" },
                new Product { Name = "Bath and Shower", ProductType = "Beuty Products" },
                new Product { Name = "Gaming Console", ProductType = "Software" },
                new Product { Name = "Antivirus", ProductType = "Software" },
                new Product { Name = "Video Games", ProductType = "Software" },
            };
        }

        /// <summary>
        /// Generic Method to display data
        /// </summary>
        /// <typeparam name="T">Generic paramter</typeparam>
        /// <param name="data">List of items</param>
        /// <param name="header">head to display</param>
        public static void ShowDummyData<T>(IEnumerable<T> data, string header)
        {
            Console.WriteLine(header);
            Console.WriteLine("-------------");
            foreach (var item in data)
            {
                if (item is Product product)
                    Console.WriteLine(product.Name);
                else
                    Console.WriteLine(item);
            }
        }
    }
}
