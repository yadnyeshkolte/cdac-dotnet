using System;
namespace ExSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Enter 1 to 10: or 0 to exit: ");
                byte n = byte.Parse(Console.ReadLine());

                if (n==0) {
                    Console.WriteLine("Bye!");
                    break;
                }

                switch (n) { 
                    case 1: 
                        Console.WriteLine("It is Case 1");
                        break;
                    case 2:
                        Console.WriteLine("It is Case 2");
                        break;
                    case 3:
                        Console.WriteLine("It is Case 3");
                        break;
                    case 4:
                        Console.WriteLine("It is Case 4");
                        break;
                    case 5:
                        Console.WriteLine("It is Case 5");
                        break;
                    case 6:
                        Console.WriteLine("It is Case 6");
                        break;
                    case 7:
                        Console.WriteLine("It is Case 7");
                        break;
                    case 8:
                        Console.WriteLine("It is Case 8");
                        break;
                    case 9:
                        Console.WriteLine("It is Case 9");
                        break;
                    case 10:
                        Console.WriteLine("It is Case 10");
                        break;
                    default: Console.WriteLine("It is default");
                        break;
                }
                
            }
        }
    }
}
