using System.Collections;

namespace ExHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>()
            {"yadnyesh", "rushik", "deepak", "madhur"};

            foreach (var s in hs) { 
                Console.WriteLine(s);
            }
            Console.WriteLine("**********");
            hs.Add("aniruddha");
            hs.Remove("deepak");

            foreach (var s in hs) { 
                Console.WriteLine(s);
            }

        }
    }
}
