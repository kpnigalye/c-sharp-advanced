using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_delegates
{
    class Program
    {
        #region Delegates Signatures
        // Used for show different ways of calling delegate
        public delegate void ArithmaticDelegate(int a, int b);

        // Generic Delegate
        public delegate T AddDel<T>(T a, T b);

        // Used for Anonymous Methods
        public delegate void OperateDel(int num);
        #endregion

        #region Target Methods
        public static void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine($"Add: {c}");
        }

        public static void Substract(int a, int b)
        {
            int c = a - b;
            Console.WriteLine($"Subtract: {c}");
        }

        public static bool CheckIfEven(int number)
        {
            return number % 2 == 0;
        }

        #endregion

        static void Main(string[] args)
        {
            #region Different ways of calling Delegates
            //// Traditional way of calling delegate using 'Invoke' function
            //ArithmaticDelegate operation1 = new ArithmaticDelegate(Add);
            //operation1.Invoke(5, 10);

            //// Assign method directly to delegate and pass arguments to delegate
            //ArithmaticDelegate operation2 = Substract;
            //operation2(15, 10);

            //// Using Lamda Expression
            //ArithmaticDelegate operation3 = (a, b) =>
            //{
            //    int c = a * b;
            //    Console.WriteLine($"Multiplication: {c}");
            //};
            //operation3(15, 10);
            #endregion

            #region Multicast Delegate
            //ArithmaticDelegate op1 = Add;
            //ArithmaticDelegate op2 = Substract;

            //ArithmaticDelegate operation = op1 + op2;

            //// Lamda Expression
            //operation += (a, b) =>
            //{
            //    int c = a / b;
            //    Console.WriteLine($"Division: {c}");
            //};

            //operation -= op1;   // deletes op1 

            //operation(20, 10);
            #endregion

            #region Generic Delegate
            //AddDel<double> sum = (a,b) =>
            //{
            //    return a + b;
            //};
            //Console.WriteLine($"Sum: {sum(3.5, 1.5)}");

            //AddDel<string> concat = (str1, str2) =>
            //{
            //    return str1 + str2;
            //};
            //Console.WriteLine($"Result String: {concat("Hello ", "World")}");
            #endregion

            #region Anonymous Methods
            //OperateDel operate = delegate (int a)
            //{
            //    Console.WriteLine($"Double of {a}: {a * 2}");
            //};
            //operate(5);

            //int p = 3;
            //OperateDel power = delegate (int a)
            //{
            //    Console.WriteLine($"Power {p} of {a}: {Math.Pow(a, p)}");
            //};
            //power(5);

            //// Lambda Expression is an evolution of anonymous method
            //// A shorter way to represnt an anonymous method
            //OperateDel operate = a => Console.WriteLine($"Square of {a}: {a * a}");
            //operate(5);
            #endregion

            #region Function Delegates
            //int n = 5;
            //Func<int, bool> func = CheckIfEven;

            //Console.WriteLine($"Is {n} an even number? {func(n)}");

            //func = (numb) => numb % 2 != 0;
            //Console.WriteLine($"Is {n} an odd number? {func(n)}");
            #endregion

            #region Action Delegates
            //Action<string> action = delegate (string message)
            //{
            //    Console.WriteLine(message);
            //};

            //action("Console Output");

            //action = (msg) => Console.WriteLine(msg);
            //action("Printer output");
            #endregion

            #region Predicate Delegates
            //Predicate<string> predicate = (string str) => str.Equals(str.ToUpper());
            //Console.WriteLine($"Is given string in capital letters? {predicate("Hello World")}");
            #endregion

            Console.ReadLine();
        }
    }
}






//CarHelper.ExecuteCarCommands();
//CartHelper.ExecuteCarCommands();
