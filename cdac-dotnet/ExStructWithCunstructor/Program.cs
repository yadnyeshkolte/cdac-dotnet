using System;
using CategoryClassLibrary_ExStructWithCunstructor;
namespace ExStructWithCunstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Category cs = new Category(200, "Electronics");

            Console.WriteLine(cs.CategoryID);
            Console.WriteLine(cs.CategoryName);
            Console.WriteLine(cs.GetCategoryNameLength());
            Console.ReadKey();

        }
        

    }
}
