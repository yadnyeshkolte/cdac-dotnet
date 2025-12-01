using System;

namespace ExThisKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person p = new Person();
            p.display();
        }
    }

    class Person {
        public int id = 10;
        public void display() {
            int id = 20;

            Console.WriteLine("Class Variable is: "+this.id);
            Console.WriteLine("Local variable is: "+id);
        }

    }
}
