namespace ExConditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 1;
            byte b = 2;
            byte c = 3;

            if (a > b && a > c)
            {
                Console.WriteLine("A is bigger no. is: " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("B is bigger no. is: " + b);
            }
            else { 
                Console.WriteLine("C is bigger no. is: " + c);
            }
        }
    }
}
