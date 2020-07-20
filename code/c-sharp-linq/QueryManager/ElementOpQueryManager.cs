using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_linq
{
    public partial class QueryManager
    {
        #region Element Operators
        public static void ExecuteElementAt(int index)
        {
            IList<string> electronics = new List<string> { "Phone", "Computer", "Laptop", "Kindle", "Smart TVs", "LED TVs" };

            "Element Operators".PrintHeader();

            // electronics.ElementAt(index) will throw an error if index is out of the range of collection
            /* electronics.ElementAtOrDefault(index) will return the default value of the type 
               if element at specified index is out of range */
            Console.WriteLine("Element at index (5): {0}", electronics.ElementAtOrDefault(index));
        }

        public static void ExecuteFirstOp()
        {
            IList<int> numbers = new List<int> { 2, 4, 6, 8, 9, 3 };
            IList<int> emptyList = new List<int>();

            "Element Operators".PrintHeader();

            try
            {
                // First() will throw an error if collection is empty
                Console.WriteLine("First Element of emptyList: {0}", emptyList.First());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nFirst Element of emptyList: {0}", emptyList.FirstOrDefault());
            }

            // FirstOrDefault() will return the default value of the type if result collection is empty
            Console.WriteLine("First Element of numbers: {0}", numbers.FirstOrDefault());
        }

        public static void ExecuteLastOp()
        {
            IList<int> numbers = new List<int> { 2, 4, 6, 8, 9, 3 };
            IList<int> emptyList = new List<int>();

            "Element Operators".PrintHeader();

            try
            {
                // Last() will throw an error if collection is empty
                Console.WriteLine("Last Element of emptyList: {0}", emptyList.Last(i => i % 2 == 0));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nLast Element of emptyList: {0}", emptyList.LastOrDefault());
            }

            // LastOrDefault() will return the default value of the type if result collection is empty
            Console.WriteLine("Last Element of numbers: {0}", numbers.LastOrDefault(i => i % 2 == 0));
        }

        public static void ExecuteSingleOp()
        {
            IList<int> numbers = new List<int> { 2, 4, 6, 8, 9, 3 };
            IList<int> emptyList = new List<int>();

            "Element Operators".PrintHeader();

            try
            {
                // Single() will throw an error if collection is empty 
                // or more than one elements are present which satisfies the condition
                Console.WriteLine("Only Element of emptyList: {0}", emptyList.Single(i => i % 2 == 0));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nOnly Element of emptyList (Prints defaut value): {0}", emptyList.SingleOrDefault());
            }
        }


        public static void ExecuteSingleOrDefaultOp()
        {
            IList<int> numbers = new List<int> { 2, 4, 6, 8, 9, 3 };
            IList<int> emptyList = new List<int>();
            "Element Operators".PrintHeader();

            try
            {
                // SingleOrDefault() will return the default value of the type if result collection contains no elements
                // that satisfies the condition
                Console.WriteLine("Only Element of numbers: {0}", numbers.SingleOrDefault(i => i > 10));

                // SingleOrDefault() will throw an exception if result collection contains more than one element
                // that satisfies the condition
                Console.WriteLine("Only Element of numbers(throws an exception): {0}", numbers.SingleOrDefault(i => i % 2 == 0));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion
    }
}
