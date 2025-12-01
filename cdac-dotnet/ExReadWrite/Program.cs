namespace ExReadWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start typing...");
            Console.ReadKey(true);  // waits for a key, doesn't echo it
            Console.WriteLine("\nNow type your line:");
            string s = Console.ReadLine();
            Console.WriteLine(s);


            Console.WriteLine("Hi there press key");
            Console.ReadKey(true);
            Console.WriteLine("Hi There");
        }
    }
}
