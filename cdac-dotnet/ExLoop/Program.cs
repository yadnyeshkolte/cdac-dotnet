using System.Runtime.CompilerServices;

namespace ExLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to calculate factorial: ");
            int n = int.Parse(Console.ReadLine());
            int decoy = n;
            int fact = 1;
            while (n>0) {
                fact *= n;
                n--;
            }

            Console.WriteLine("Factorial of number: " + decoy + " is " + fact);
            Console.WriteLine("Enter any key to continue: ");
            Console.ReadKey();
            fact = 1;

            for (int i=1;i<=decoy;i++) {
                fact *= i; 
            }
            Console.WriteLine("Factorial of the decoy Number: "+decoy+ " is "+fact);
        }
    }
}
