using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Press any key to continue Q1: ");
            Console.ReadKey();
            Console.Write("Enter the radius of the circle: ");
            float radius = float.Parse(Console.ReadLine());
            float pi = 3.14f;
            Console.WriteLine("The area of the circle is: " + (pi * radius * radius));


            Console.Write("Press any key to continue Q2: ");
            Console.ReadKey();
            Console.WriteLine(" ");
            Console.Write("Enter height in (inches): ");
            float height = float.Parse(Console.ReadLine());
            float incms = 2.54f * height;
            if (incms < 150)
            {
                Console.WriteLine("It is in short.");
            }
            else if (incms >= 150 && incms < 170)
            {
                Console.WriteLine("It is in medium.");
            }
            else if (incms >= 170 && incms < 190)
            {
                Console.WriteLine("It is in tall.");
            }
            else
            {
                Console.WriteLine("It is in very tall.");
            }


            Console.Write("Press any key to continue Q3: ");
            Console.ReadKey();
            Console.WriteLine(" ");
           
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            if (number > 99999) { 
                Console.WriteLine(99000);
            }
            if (number <= 999)
            {
                Console.WriteLine(1000);
            }
            else {
                int decoy = number;
                decoy = decoy / 1000;

                if (number - decoy*1000 < (decoy + 1)*1000 - number)
                {
                    Console.WriteLine(decoy * 1000);
                }
                else { 
                    Console.WriteLine((decoy + 1) * 1000);
                }

            }
        }
    }
}
