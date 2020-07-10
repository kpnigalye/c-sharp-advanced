using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                new Product { Name = "antivirus", ProductType = "Software" },
                new Product { Name = "Video Games", ProductType = "Software" },
            };
        }
    }
}
