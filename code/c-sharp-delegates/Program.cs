using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_delegates
{
    static class ConsoleHeaderWriter
    {
        // Extension method for Print header
        public static void PrintHeader(this string header, char underlineChar = '-')
        {
            Console.WriteLine("{0}", header);
            Console.WriteLine("{0}\n", new string(underlineChar, header.Length + 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //CarHelper.ExecuteCarCommands();

            CartHelper.ExecuteCarCommands();
        }

    }
}
