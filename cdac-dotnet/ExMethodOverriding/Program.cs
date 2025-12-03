using System;

namespace ExMethodOverriding
{

    class Person {
        public string personName;
        public string gender;

        public virtual void displayDetails() { 
            Console.WriteLine("Person Name: " + personName);
            Console.WriteLine("Person's Gender is: "+gender);
        }

    }

    class Student : Person {
        public int studId;
        public float percentage;

        public override void displayDetails() { 
            base.displayDetails();
            Console.WriteLine("Student ID: " + studId);
            Console.WriteLine("Student Percentage: " + percentage); 
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person person = new Person();
            person.personName = "John Doe";
            person.gender = "Male";
            person.displayDetails();    

            Console.WriteLine("**************************");
            Student student = new Student();
            student.studId = 8;
            student.percentage = 90.0f;
            student.displayDetails();
            Console.ReadKey();
        }
    }
}
