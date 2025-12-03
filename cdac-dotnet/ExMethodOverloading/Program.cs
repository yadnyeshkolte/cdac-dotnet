using System;

namespace ExMethodOverloading
{

    class TestOverLoad
    {
        public void AddNumber(int x, int y)
        {
            int z;
            z = x + y;
            Console.WriteLine("Result of Add Two Integers is   " + z.ToString());
            Console.ReadLine();
        }
        public void AddNumber(int x, int y, int z)
        {

            int a;
            a = x + y + z;
            Console.WriteLine("Result of Add Three Integers is   " + a.ToString());
            Console.ReadLine();

        }
        public void AddNumber(double x, double y)
        {
            double z;
            z = x + y;
            Console.WriteLine("Result of Add Two Decimals is   " + z.ToString());
            Console.ReadLine();
        }
        public void AddNumber(string x, string y)
        {
            Console.WriteLine("Result of Concatinating Two Strings is   " + x + y);
            Console.ReadLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TestOverLoad t = new TestOverLoad();

            t.AddNumber(1, 2);
            t.AddNumber(15, 36, 55);
            t.AddNumber(34.5, 67.5);
            t.AddNumber("C-DAC", "Bangalore");
            Console.ReadKey();
        }
    }
}