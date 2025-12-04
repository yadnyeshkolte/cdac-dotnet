namespace ExReverseList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>() {2,6,1,3,9,4};

            li.Sort();
            li.Reverse();

            foreach (var item in li)
            {
                Console.Write(item+" ");
            }

            Console.ReadKey();
        }
    }
}
