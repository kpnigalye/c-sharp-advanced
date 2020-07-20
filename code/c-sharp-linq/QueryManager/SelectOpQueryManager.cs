using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp_linq
{
    public partial class QueryManager
    {
        /// <summary>
        /// Using 'Select' clause
        /// </summary>
        public static void ExecuteSelectClause()
        {
            IList<Student> studentList = StudentData.GetStudentData();
            // Using Method Syntax
            //var result = studentList.Select(a => new { a.Name, a.Skills });

            var result = from s in studentList
                         select new { s.Name, s.Skills };

            "Select Clause".PrintHeader();

            foreach (var student in result)
            {
                Console.WriteLine(student.Name);
                foreach (var skill in student.Skills)
                {
                    Console.WriteLine($"\t{skill}");
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Using 'SelectMany' clause
        /// </summary>
        public static void ExecuteSelectManyClause()
        {
            IList<Student> studentList = StudentData.GetStudentData();

            var skills = studentList.SelectMany(a => a.Skills);

            "SelectMany Clause".PrintHeader();

            foreach (var item in skills)
            {
                Console.WriteLine(item);
            }
        }

    }
}
