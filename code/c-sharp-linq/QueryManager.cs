using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_linq
{
    public class QueryManager
    {
        public static dynamic DisplayDataByInnerJoin(in IEnumerable<string> productTypes, in IEnumerable<Product> products)
        {
            // unlike = sign linq has 'equals' 
            // creates anonymous objects with -->  select new { e.Name, Category = e.ProductType };
            var result = from r in productTypes
                         join e in products on r equals e.ProductType
                         select new { e.Name, Category = e.ProductType };
            return result;
        }
    }
}
