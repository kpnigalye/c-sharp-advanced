using System;

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
}
