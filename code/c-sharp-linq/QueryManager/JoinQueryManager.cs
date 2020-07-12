using System.Collections.Generic;
using System.Linq;

namespace c_sharp_linq
{
    public partial class QueryManager
    {
        /// <summary>
        /// Inner Join
        /// </summary>
        public static dynamic ExecuteInnerJoin(in IEnumerable<string> productTypes, in IEnumerable<Product> products)
        {
            // Using Method Syntax
            //var result = products.Join( // outer
            //    productTypes    // inner
            //    , product => product.ProductType    // inner key selector
            //    , productType => productType        // outer key selector
            //    , (product, productType) => new     // result formation
            //    {
            //        product.Name,
            //        Category = product.ProductType
            //    });

            var result = from r in productTypes
                         join p in products 
                         on r equals p.ProductType
                         select new { p.Name, Category = p.ProductType };
            return result;
        }

        /// <summary>
        /// Group Join
        /// Allows you to group data according to a param
        /// </summary>
        public static dynamic ExecuteGroupJoin(in IEnumerable<string> productTypes, in IEnumerable<Product> products)
        {
            // Using Method Syntax
            //var result = productTypes.GroupJoin(// outer
            //    products   // inner
            //    , productType => productType        // outer key selector
            //    , product => product.ProductType    // inner key selector
            //    , (productType, matchedProducts) => new     // result formation
            //    {
            //        Products = matchedProducts,
            //        Category = productType
            //    });

            var result = from r in productTypes
                         join p in products 
                         on r equals p.ProductType 
                         into pd
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
                         join p in products 
                         on r equals p.ProductType 
                         into pd
                         from p in pd.DefaultIfEmpty()
                         select new { Category = r, Name = p == null ? "No Product" : p.Name };

            // Alternate way to write left join query
            //var result = from r in productTypes
            //             join p in products
            //             on r equals p.ProductType
            //             into pd
            //             from p in pd.DefaultIfEmpty(new Product { Name = "No Product" })
            //             select new { Category = r, p.Name };

            return result;
        }

    }
}
