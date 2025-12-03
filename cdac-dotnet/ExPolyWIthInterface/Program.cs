using System;

namespace ExPolyWIthInterface
{
    interface IAnimal
    {
        string name { get; set; }
        string breed { get; set; }

        void animalDetails();
    }

    class Dog : IAnimal { 
        public string name { get; set; }
        public string breed { get; set; }

        public void animalDetails()
        {
            Console.WriteLine("Dog Details");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Breed: "+breed);
        }

    }

    class Cat: IAnimal
    {
        public string name { get; set; }
        public string breed { get; set; }
        public void animalDetails()
        {
            Console.WriteLine("Cat Details");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Breed: " + breed);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal a;
            a = new Dog() { name = "Tommy", breed = "Bulldog" };
            a.animalDetails();

            a = new Cat();
            a.name = "Misty";  
            a.breed = "Persian";
            a.animalDetails();
            Console.ReadKey();
        }


    }
}
