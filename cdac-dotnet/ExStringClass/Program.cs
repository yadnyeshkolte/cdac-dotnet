using System.Text;

namespace ExStringClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Yadnyesh";

            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.Length);
            Console.WriteLine(s.Substring(4));
            Console.WriteLine(s.Substring(6));
            Console.WriteLine(s.Insert(3,"ii"));
            Console.WriteLine(s.Remove(4)); // remove from this 4th number
            Console.WriteLine(s.Replace('n','o'));
            Console.WriteLine(s.IndexOf("y"));
            Console.ReadKey();  
        }
    }
}
