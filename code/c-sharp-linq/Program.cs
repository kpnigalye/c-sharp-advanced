using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_linq
{
    partial class Program
    {
        static void Main(string[] args)
        {
            ShowInnerJoin();

            Console.ReadLine();
        }

        static void ShowInnerJoin()
        {
            var productTypes = ProductStore.GetProductTypes();
            var products = ProductStore.GetProducts();

            // unlike = sign linq has 'equals' 
            // creates anonymous objects with -->  select new { e.Name, Category = e.ProductType };
            var result = from r in productTypes
                         join e in products on r equals e.ProductType
                         select new { e.Name, Category = e.ProductType };

            foreach(var item in result)
            {
                Console.WriteLine($"{item.Name} --> {item.Category}");
            }
        }
    }
}
