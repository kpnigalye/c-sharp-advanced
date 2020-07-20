using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_linq
{
    public partial class QueryManager
    {
        #region Aggregate Method
        public static void ExecuteAggregateMethod()
        {
            IList<string> electronics = new List<string> { "Phone", "Computer", "Laptop", "Kindle", "Smart TVs", "LED TVs" };

            "Aggregate Method".PrintHeader();
            Console.WriteLine(electronics.Aggregate((item1, item2) => item1 + ", " + item2));
        }
                
        public static void ExecuteAggregateMethodWithSeed()
        {
            IList<string> electronics = new List<string> { "Phone", "Computer", "Laptop", "Kindle", "Smart TVs", "LED TVs" };

            "Aggregate Method".PrintHeader();
            Console.WriteLine(electronics.Aggregate("Available Electronics: ", (str, item2) => str += item2 + ", "));
        }
        
        public static void ExecuteAggregateMethodForAddition()
        {
            IList<Student> students = StudentData.GetStudentData();

            "Aggregate Method".PrintHeader();
            Console.WriteLine("Total Age: {0}", students.Aggregate(0, (totalAge, student) => totalAge += student.Age));
        }

        public static void ExecuteAggregateMethodWithResult()
        {
            IList<Student> students = StudentData.GetStudentData();

            string names = students.Aggregate("Names: ",
                (str, s) => str += s.Name + ",",
                str => str.Substring(0, str.Length - 1));

            "Aggregate Method".PrintHeader();
            Console.WriteLine(names);
        }
        #endregion

        #region Average Method
        public static void ExecuteAverageMethod()
        {
            IList<int> allAges = StudentData.GetStudentData().Select(a => a.Age).ToList();

            "Average Method".PrintHeader();
            Console.WriteLine("Average Age: {0}", allAges.Average());
        }
        #endregion

        #region Count Method
        public static void ExecuteCountMethod()
        {

            int count = StudentData.GetStudentData().Count();

            Console.WriteLine("Number of Students: {0}", count);
        }

        public static void ExecuteCountMethodWithCondition()
        {
            int count = StudentData.GetStudentData().Count(a => a.Age > 20);

            "Count Method".PrintHeader();
            Console.WriteLine("Number of Students whose age is above 20: {0}", count);
        }
        #endregion

        #region Mix and Max Methods
        public static void ExecuteMinMaxMethod()
        {
            int maxAge = StudentData.GetStudentData().Max(a=>a.Age);
            int minAge = StudentData.GetStudentData().Min(a=>a.Age);

            "Use of Min-Max Methods".PrintHeader();
            Console.WriteLine("Min Age: {0}", minAge);
            Console.WriteLine("Max Age: {0}", maxAge);
        }
        #endregion

        #region Sum Method
        // Sum of the ages of students where age is a even number
        public static void ExecuteSumMethod()
        {
            int sum = StudentData.GetStudentData().Sum(a =>
            {
                if (a.Age % 2 == 0)
                    return a.Age;
                else
                    return 0;
            });

            "Use of Sum Method with a condition".PrintHeader();
            Console.WriteLine("Sum of Even Ages: {0}", sum);
        }
        #endregion
    }
}
