namespace ExPartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();

            obj.AddNumber(10, 10);
            obj.Hello("Amruta");
            obj.MultiplyNumbers(5, 5);
            obj.Bye();
            Console.ReadKey();


        }
    }

    //create a class called "Test" in "ExOfPartialClass" namespace.
    //This is a partial class. So at compilation time, the code for
    //Test.cs also will be combined with this class.
    public partial class Test
    {
        public void AddNumber(int x, int y)
        {
            int z;
            z = x + y;
            Console.WriteLine("Result of Add is " + z);
            Console.ReadLine();
        }

        public void Hello(string name)
        {
            Console.WriteLine("Hello How Are You " + name);
            Console.ReadLine();
        }
    }

    //create a class called "Test" in "ExOfPartialClass" namespace.
    //This is a partial class. So at compilation time, the code for
    //Test.cs also will be combined with this class.
    public partial class Test
    {
        public void MultiplyNumbers(int x, int y)
        {
            int z;
            z = x * y;
            Console.WriteLine("Result of Mutl is " + z);
            Console.ReadLine();
        }

    }

}
