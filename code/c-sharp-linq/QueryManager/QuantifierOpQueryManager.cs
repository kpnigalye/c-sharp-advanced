using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp_linq
{
    public partial class QueryManager
    {
        #region Quantifiers Operator
        /// <summary>
        /// Query using 'All' operator
        /// </summary>
        public static void ExecuteOperator_All()
        {
            IList<Student> studentList = StudentData.GetStudentData();

            // Using Method Syntax
            bool result = studentList.All(a => a.Age > 15 && a.Age < 22);

            Console.WriteLine("Result of All operator: {0}", result);
        }

        /// <summary>
        /// Query using 'Any' operator
        /// </summary>
        public static void ExecuteOperator_Any()
        {
            IList<Student> studentList = StudentData.GetStudentData();

            // Using Method Syntax
            bool result = studentList.Any(a => a.Age < 20);

            Console.WriteLine("Result of Any operator: {0}", result);
        }

        #endregion

        #region Contains operator

        public static void ExecuteOperator_ContainsUsingCollections()
        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine($"Does list contains 0? {nums.Contains(0)}");
            Console.WriteLine($"Does list contains 5? {nums.Contains(5)}");
        }

        public static void ExecuteOperator_Contains(in IEnumerable<Product> products)
        {
            Product product = new Product { Name = "Laptop", ProductType = "Electronics" };

            Console.WriteLine($"Does Product List contains our product? " +
                $"{products.Contains(product, new ProductComparer())}");
        }

        // Class that implements 'IEqualityComparer' interface to compare custom objects
        class ProductComparer : IEqualityComparer<Product>
        {
            public bool Equals(Product x, Product y)
            {
                if (x.Name == y.Name && x.ProductType == y.ProductType)
                    return true;

                return false;
            }

            public int GetHashCode(Product obj)
            {
                return obj.GetHashCode();
            }
        }
    }

    #endregion
}
