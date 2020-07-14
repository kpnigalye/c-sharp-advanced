using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp_linq
{
    public partial class QueryManager
    {
        /// <summary>
        /// Using 'Where' clause
        /// Select Products where ProductType is Software or Books
        /// </summary>
        public static dynamic ExecuteWhereClause(in IEnumerable<Product> products)
        {
            // Using Method Syntax
            //var result = products.Where(a => a.ProductType == "Software");

            var result = from r in products
                         where r.ProductType is "Software" || r.ProductType is "Books"
                         select new { r.Name, Category = r.ProductType };
            return result;
        }

        /// <summary>
        /// Using 'OrderBy' clause
        /// </summary>
        public static dynamic ExecuteOrderByClause(in IEnumerable<Product> products)
        {
            // Using Method Syntax
            //var result = products.OrderBy(a => a.ProductType);

            var result = from r in products
                         orderby r.ProductType
                         select new { r.Name, Category = r.ProductType };
            return result;
        }

        /// <summary>
        /// Query using Combination of Where and OrderBy clauses
        /// </summary>
        public static dynamic ExecuteWhereAndOrderByClause(in IEnumerable<Product> products)
        {
            // Using Method Syntax
            //var result = products.Where(p => p.ProductType == "Books").OrderByDescending(a => a.Name);

            var result = from r in products
                         where r.ProductType is "Books"
                         orderby r.Name descending
                         select new { r.Name, Category = r.ProductType };
            return result;
        }

        /// <summary>
        /// Query using ThenBy clause
        /// </summary>
        public static dynamic ExecuteThenByClause(in IEnumerable<Product> products)
        {
            // Using Method Syntax
            //var result = products.OrderBy(a => a.ProductType).ThenByDescending(b => b.Name);

            var result = from r in products
                         orderby r.ProductType, r.Name descending
                         select new { r.Name, Category = r.ProductType };
            return result;
        }

        /// <summary>
        /// Query using GroupBy clause
        /// </summary>
        public static void ExecuteGroupByClause()
        {
            IList<Student> studentList = StudentData.GetStudentData();

            // Using Method Syntax
            //var groupedResult = studentList.GroupBy(a => a.Age);

            var groupedResult = from s in studentList
                                group s by s.Age;

            //iterate each group        
            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine("\nAge Group: {0}", ageGroup.Key); //Each group has a key 
                Console.WriteLine("-----------------");
                foreach (Student s in ageGroup) // Each group has inner collection
                    Console.WriteLine("Student Name: {0}", s.Name);
            }
        }

        /// <summary>
        /// Query using ToLookUp clause
        /// </summary>
        public static void ExecuteToLookUp()
        {
            IList<Student> studentList = StudentData.GetStudentData();

            // Using Method Syntax
            var groupedResult = studentList.ToLookup(a => a.Age);

            //iterate each group        
            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine("\nAge Group: {0}", ageGroup.Key); //Each group has a key 
                Console.WriteLine("-----------------");
                foreach (Student s in ageGroup) // Each group has inner collection
                    Console.WriteLine("Student Name: {0}", s.Name);
            }
        }
    }
}
