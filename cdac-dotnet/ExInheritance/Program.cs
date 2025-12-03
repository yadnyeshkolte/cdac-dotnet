using System.Transactions;

namespace ExInheritance
{
    public class Mycar
    {
        public int tyre = 4;
        public int steering = 1;
        public Mycar()
        {
            Console.WriteLine("I Purchased Car");
            Console.ReadLine();
        }

        public void Features()
        {
            Console.WriteLine("It is A Luxury Vehicle");
            Console.ReadLine();
        }
        public void Fuel()
        {
            Console.WriteLine("It uses Petrol As Fuel");
            Console.ReadLine();
        }
    }
    public class Hyundai : Mycar
    {
        public Hyundai()
        {
            tyre = 5;
            steering = 4;
        }
        public void NewFeatures()
        {
            Console.WriteLine("It Has A/C and Central Locking");
            Console.ReadLine();
        }

        public void Show()
        {
            Console.WriteLine("It Can Work on Disel and Lpg Also");
            Console.ReadLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            /*
             - When you create a Hyundai object, first the base class constructor (Mycar()) runs, then the child constructor (Hyundai()).
 
            • 	In Java, if you want to call the parent constructor explicitly, you use .
            • 	In C#, the parent constructor is always called automatically before the child constructor, unless you specify otherwise.
            */

            Console.WriteLine("Parenent Class Details");
            Mycar mycar = new Mycar();
            mycar.Features();
            mycar.Fuel();
            Console.WriteLine("Child  Class Details");
            Hyundai myhyundai = new Hyundai();
            myhyundai.Features();
            myhyundai.Fuel();
            myhyundai.NewFeatures();
            myhyundai.Show();
            Console.WriteLine("Your Car Has Tyres  " + mycar.tyre);
            Console.WriteLine("Your Car Has Steering  " + mycar.steering);

            Console.WriteLine("Your Child hyundai Car Has Tyres  " + myhyundai.tyre);
            Console.WriteLine("Your Child hyundai Car Has Steering  " + myhyundai.steering);

            Console.ReadKey();
        }
    }

}
