using System.Runtime.CompilerServices;

namespace ExDatatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 200;
            ushort ush = 34000;
            short sh = 30000;
            int i = 500000;
            uint ui = 5000000;
            float f = 1.0f;
            double du = 5542442;
            long l = 5000000;
            ulong ul = 50000000;
            decimal dec = 5000004555555555525;

            char ch = 'a';
            string s = "uio";
            System.Console.WriteLine("Enter any key to continue: --> ");
            System.Console.ReadKey();
            Console.WriteLine(b);
            Console.WriteLine(ush);
            Console.WriteLine(sh);
            Console.WriteLine(i);
            Console.WriteLine(ui);
            Console.WriteLine(f);
            Console.WriteLine(du);
            Console.WriteLine(l);
            Console.WriteLine(ul);
            Console.WriteLine(dec);
            Console.WriteLine(ch);
            Console.WriteLine(s);

        }
    }
}
