using System;
using System.Diagnostics;

namespace ExStaticVariable
{
    class Employee
    {
        public static int inc = 10;
        public static int dec = 10;

        public void increment() { 
            inc++; 
        }
        public void decrement() { 
            dec--;
        }

        public void display() {
            Console.WriteLine("Increment is: "+inc+" Decrement is: "+dec);
        }

    }
}
