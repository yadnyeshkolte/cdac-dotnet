using System;

namespace ExClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Library l1 = new Library();

            l1.id = 1;
            l1.book = "My book";
            Console.WriteLine(l1.id);
            Console.WriteLine(l1.book);

            Console.WriteLine("Enter the any key to continue: ");
            Console.ReadKey();
            Library l2 = new Library();
            l2.id = 2;
            l2.book = "Hui";
            Console.WriteLine(l2.id);
            Console.WriteLine(l2.book);
        }
    }
}
