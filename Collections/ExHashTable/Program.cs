using System.Collections;

namespace ExHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable()
            { {1, "hii"},{2, "ther "}, {"Their",45}, {34.5,'c'} };

            foreach (var item in hash) { 
                Console.WriteLine(item);    
            }

            hash.Add(5, "new value added");
            hash[2] = "value at key 2 modified";

            hash.Remove(34.5);
            Console.WriteLine("**********");
            hash.Remove("Their");
            foreach (var item in hash) {
                Console.WriteLine(item);

            }

        }
    }
}
