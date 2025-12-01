using System;

namespace ExStaticVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Employee!");
            Console.WriteLine("Increment is: " + Employee.inc + " Decrement is: " + Employee.dec);
            Employee e1 = new Employee();
            e1.increment();
            e1.display();
            Employee e2 = new Employee();
            e2.decrement();
            e2.display();
            Employee e3 = new Employee();
            e3.increment();
            e3.display();

        }
    }
}
