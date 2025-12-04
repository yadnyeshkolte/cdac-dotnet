using System.Collections;

namespace ExSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sd = new SortedList<int, string>()
            {
                {103, "yoy it"},
                {101, "hii"},
                {102, "There"}
            };

            foreach (KeyValuePair<int, string> item in sd) { 
                Console.WriteLine(item.Key + " = key " + item.Value + " =value");
            }


            sd.Add(100, "Theere it is");
            sd.Remove(102);
            Console.WriteLine("********** After adding and removing **********");

            foreach (KeyValuePair<int, string> item in sd)
            {
                Console.WriteLine(item.Key + " = key " + item.Value + " =value");
            }
        }
    }
}
