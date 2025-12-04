namespace Method_PropOfList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(10);
            li.Add(20);
            li.Add(30);

            foreach (var a in li)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine("*****************");
            List<int> list = new List<int>();
            list.Add(100);
            list.Add(200);
            list.Add(300);

            li.AddRange(list);

            foreach (var a in li)
            {
                Console.Write(a + " ");
            }

            Console.ReadKey();
        }
    }
}
