using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_linq
{
    partial class Program
    {
        static void Main(string[] args)
        {
            ShowInnerJoin();

            Console.ReadLine();
        }

        static void ShowInnerJoin()
        {
            var roles = DataStore.GetRoles();
            var employees = DataStore.GetEmployees();

            // unlike = sign linq has 'equals' 
            // creates anonymous objects with --> select new { e.Name, e.Role };
            var result = from r in roles
                         join e in employees on r equals e.Role
                         select new { e.Name, e.Role };
            
            foreach(var emp in result)
            {
                Console.WriteLine($"{emp.Name} --> {emp.Role}");
            }
        }
    }
}
