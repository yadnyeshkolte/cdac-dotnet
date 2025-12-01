using System;
using System.Diagnostics;

namespace ExOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int a = 9; int b = 10;
            Console.WriteLine("Enter any key to continue: ");
            Console.ReadKey();
            Console.WriteLine("Addition is: "+(a+b));
            Console.WriteLine("Substraction is: "+(a-b));
            Console.WriteLine("Multiplication is: "+(a*b));
            Console.WriteLine("Division is: "+ (a/b));
            Console.WriteLine("Mod is: "+(a%b));

            Console.WriteLine("Enter key to continue to booleans: ");
            Console.ReadKey();

            bool c = a > b;
            Console.WriteLine(c);
            c = a < b;
            Console.WriteLine(c);
            c = (a == b);
            Console.WriteLine(c);
            c = (a != b);
            Console.WriteLine(c);
            c = (a >= b);
            Console.WriteLine(c);
            c = (a <= b);
            Console.WriteLine(c);

            Console.WriteLine("*****-- For Ternary operator --*****");
            Console.ReadKey();
            byte n = 0;
            string s = (n == 0) ? "Passed" : "Failed";
            Console.WriteLine(s);
        }
    }
}
