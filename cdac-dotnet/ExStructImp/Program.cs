
using System;
using CategoryClassLibrary; 
namespace ExStructImp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category cs = new Category();

            cs.CategoryId = 1;
            cs.CategoryName = "yadnyesh";

            Console.WriteLine(cs.CategoryId);
            Console.WriteLine(cs.CategoryName); 

            Console.WriteLine(cs.getNameLength());

            Console.ReadKey();
        }
    }
}
