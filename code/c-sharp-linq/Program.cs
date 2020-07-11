using System;

namespace c_sharp_linq
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var productTypes = ProductStore.GetProductTypes();
            var products = ProductStore.GetProducts();

            ProductStore.ShowDummyData<string>(productTypes, "Product Types");
            ProductStore.ShowDummyData<Product>(products, "\nProducts");

            Console.ReadLine();
        }
    }
}







//// Inner Join
//var result = QueryManager.DisplayDataByInnerJoin(in productTypes, in products);

//            foreach (var item in result)
//            {
//                Console.WriteLine($"{item.Name} --> {item.Category}");
//            }