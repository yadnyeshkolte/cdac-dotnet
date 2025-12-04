namespace ExMathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = -59;
            int i = Math.Abs(n);
            Console.WriteLine("Abs is: "+i);

            double d = 45.9343;
            Console.WriteLine("Double is: "+d);    
            double a = Math.Floor(d);
            Console.WriteLine("Math floor is: "+a);

            double b = Math.Ceiling(d);
            Console.WriteLine("Math seling is: "+b);

            double c = Math.Round(d);
            Console.WriteLine("Math Round is: "+c);

            int a1 = 89;
            int b1 = 45;
            int c1 = Math.Max(a1, b1);
            Console.WriteLine("Maximum is: "+c1);


            Console.ReadKey();
        }
    }
}
