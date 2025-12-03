using System;

namespace ExMultiInterface
{
    interface ICar {
        void display();
    }

    class Honda: ICar{
        public void display() { 
            Console.WriteLine("This is Honda Car");
        }
    }

    interface IFirst {
        void add(int a, int b);
    }
    interface ISecond {
        void add(int a, int b);
    }

    class Calculation: IFirst, ISecond {
        void IFirst.add(int a, int b)
        {
            Console.WriteLine("Sum of two integers for First Interface: " + (a + b));   
        }
        void ISecond.add(int a, int b)
        {
            Console.WriteLine("Sum of two integers for Second Interface: " + (a + b));  
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Honda honda = new Honda();
            honda.display();

            IFirst first = new Calculation();
            ISecond second = new Calculation();

            first.add(10, 20);
            second.add(40, 59);
            Console.ReadKey();

        }
    }
}
