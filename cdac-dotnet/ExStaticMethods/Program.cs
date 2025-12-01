using System;

namespace ExStaticMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers to print ?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i=0;i<n;i++) {
                Console.Write(fibonacciSeries(i)+" ");
            }
            

        }

        static int fibonacciSeries(int n) {
            if (n==0 || n==1) {
                return 1;
            }
            return fibonacciSeries(n-1)+fibonacciSeries(n-2);
        }
    }
}
