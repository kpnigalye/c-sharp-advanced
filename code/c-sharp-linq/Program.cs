using System;
using System.Linq;

namespace c_sharp_linq
{
    partial class Program
    {
        static void Main()
        {
            var productTypes = ProductStore.GetProductTypes();
            var products = ProductStore.GetProducts();

            #region Display Data
            //ProductStore.ShowDummyData<string>(productTypes, "Product Types");
            //ProductStore.ShowDummyData<Product>(products, "\nProducts");
            #endregion

            #region Simple Queries
            
            //DisplayResult("Simple Queries", QueryManager.ExecuteOrderByClause(products));
            
            //DisplayResult("Simple Queries", QueryManager.ExecuteOrderByClause(products));

            //DisplayResult("Simple Queries", QueryManager.ExecuteWhereAndOrderByClause(products));

            DisplayResult("Simple Queries", QueryManager.ExecuteThenByClause(products));

            #endregion

            #region Inner Join
            //DisplayResult("Inner Join", QueryManager.ExecuteInnerJoin(in productTypes, in products));
            #endregion

            #region Group Join
            /*
            var result = QueryManager.ExecuteGroupJoin(in productTypes, in products);

            Console.WriteLine("Group Join");
            Console.WriteLine("-------------\n");

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Category}");
                foreach(var p in item.Products)
                {
                    Console.WriteLine($"\t{p.Name}");
                }
            }
            */
            #endregion
            #region Left Outer Join
            //DisplayResult("Left Join", QueryManager.ExecuteLeftJoin(in productTypes, in products));
            #endregion
            Console.ReadLine();
        }


        /// <summary>
        /// Method to display result of the query
        /// </summary>
        /// <param name="result">Result of the LINQ</param>
        private static void DisplayResult(string header, dynamic result)
        {
            Console.WriteLine(header);
            Console.WriteLine("-------------\n");

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Category} : {item.Name}");
            }
            Console.WriteLine();
        }
    }
}







