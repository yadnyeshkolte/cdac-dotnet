using System.Collections;
using System.Security.Cryptography.X509Certificates;
namespace ExDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> dics = new Dictionary<int, string>()
            {
                {101, "hii"},
                {102, "There"},
                {103, "yoy it"}
            };

            foreach (KeyValuePair<int, string> item in dics) {
                Console.WriteLine(item.Key+" = key"+item.Value+" =value");
            }

            string s = dics[101];
            Console.WriteLine("value at key 101 is "+s);
            Console.WriteLine("**********");
            Dictionary<int, string>.KeyCollection keyc = dics.Keys;
            foreach (int item in keyc) { 
                Console.WriteLine("key is "+item);

            }
            Console.WriteLine("**********");
            Dictionary<int, string>.ValueCollection valuec = dics.Values;
            foreach (string item in valuec)
            {
                Console.WriteLine("value is " + item);
            }

            Console.ReadKey();
        }
    }
}
