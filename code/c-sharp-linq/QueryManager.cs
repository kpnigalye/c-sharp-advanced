using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_linq
{
    public class QueryManager
    {
        /// <summary>
        /// Inner Join
        /// </summary>
        public static dynamic ExecuteInnerJoin(in IEnumerable<string> productTypes, in IEnumerable<Product> products)
        {
            // unlike = sign linq has 'equals' 
            // creates anonymous objects with -->  select new { e.Name, Category = e.ProductType };
            var result = from r in productTypes
                         join p in products on r equals p.ProductType
                         select new { p.Name, Category = p.ProductType };
            return result;
        }

        /// <summary>
        /// Group Join
        /// Allows you to group data according to a param
        /// </summary>
        public static dynamic ExecuteGroupJoin(in IEnumerable<string> productTypes, in IEnumerable<Product> products)
        {
            var result = from r in productTypes
                         join p in products on r equals p.ProductType into pd
                         select new { Category = r, Products = pd };
            return result;
        }

        /// <summary>
        /// Left Join
        /// Gives all records from left and matching records from right
        /// </summary>
        public static dynamic ExecuteLeftJoin(in IEnumerable<string> productTypes, in IEnumerable<Product> products)
        {
            var result = from r in productTypes
                         join p in products on r equals p.ProductType into pd
                         from p in pd.DefaultIfEmpty()
                         select new { Category = r, Name = p == null ? "No Product" : p.Name };
            return result;
        }

        /// <summary>
        /// Right Join
        /// Gives all records from right and matching records from left
        /// </summary>
        public static dynamic ExecuteRightJoin(in IEnumerable<string> productTypes, in IEnumerable<Product> products)
        {
            var result = from r in productTypes
                         join p in products on r equals p.ProductType into pd
                         from p in pd.DefaultIfEmpty(new Product { Name = "No Product" })
                         select new { Category = r, p.Name };

            /*
            var result = from r in productTypes
                         join p in products on r equals p.ProductType into pd
                         from p in pd.DefaultIfEmpty()
                         select new { Category = r, Name = p == null ? "No Product" : p.Name };
            */
            return result;
        }
    }
}
