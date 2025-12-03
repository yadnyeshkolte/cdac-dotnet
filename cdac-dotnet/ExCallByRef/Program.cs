namespace ExCallByRef
{
        class Sample
        {
            public void Method1(ref int x)
            {
                x = 150;

                Console.WriteLine("Output inside the methodL " + x); //Output: 150

            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
            //same as out
                Sample s;
                s = new Sample();
                int a = 6;
                Console.WriteLine("Before entering method: " + a);
                s.Method1(ref a);
                Console.WriteLine("Before Out from method: " + a);
                Console.ReadKey();

            }
    }
}
