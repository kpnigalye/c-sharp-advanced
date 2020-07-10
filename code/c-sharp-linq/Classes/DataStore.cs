using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_linq
{
    /// <summary>
    /// Class to populate temp data
    /// </summary>
    public static class DataStore
    {
        public static IEnumerable<string> GetRoles()
        {
            return new string[]
            {
                "Manager",
                "Lead",
                "Developer",
                "Tester",
                "Support",
                "QA"
            };
        }

        public static IEnumerable<Employee> GetEmployees()
        {
            return new Employee[]
            {
                new Employee { Name = "Som", Role = "Manager" },
                new Employee { Name = "Mangal", Role = "Lead" },
                new Employee { Name = "Budh", Role = "Lead" },
                new Employee { Name = "Guru", Role = "Developer" },
                new Employee { Name = "Shukra", Role = "Developer" },
                new Employee { Name = "Shani", Role = "Developer" },
                new Employee { Name = "Ravi", Role = "Developer" },
                new Employee { Name = "Bhanu", Role = "Developer" },
                new Employee { Name = "Tejas", Role = "Support" },
            };
        }
    }
}
