using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class TypeOf
    {
        public static void main()
        {
            Console.WriteLine("The type of 42 is: " + typeof(int));
            Console.WriteLine("The type of 'Hello' is: " + typeof(string));
            Console.WriteLine("The type of 3.14 is: " + typeof(double));
            Console.WriteLine("The type of true is: " + typeof(bool));
            Console.WriteLine("The type of DateTime.Now is: " + typeof(DateTime));
            Console.WriteLine("The type of List<int> is: " + typeof(List<int>));
            Console.WriteLine("The type of Dictionary<string, int> is: " + typeof(Dictionary<string, int>));
            Console.WriteLine("The type of char is: " + typeof(char));
            Console.WriteLine("The type of float is: " + typeof(float));

            int a = 40;
            short b = (short)a;
            Console.WriteLine("The type of b = "+ b +" after casting a to short is: " + typeof(short));

            string s = "343";
            int c = int.Parse(s);
            Console.WriteLine("The type of c = "+ c  +" after parsing s to int is: " + typeof(int));

            string d = "3";
            int n = Convert.ToInt32(d);
            Console.WriteLine("The type of n = "+ n  +" after converting d to int is: " + typeof(int));



        }
    }
}
