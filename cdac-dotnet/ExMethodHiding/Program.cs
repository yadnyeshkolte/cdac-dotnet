using System;

namespace ExMethodHiding
{

    class Person {
        public string personname;
        public string gender;

        public void display()
        {
            Console.WriteLine("Person Name: " + personname);
            Console.WriteLine("Person's Gender is: "+ gender);
        }
    }
    class Employee : Person {
        public int empId;
        public int salary;
        public void display() { 
            Console.WriteLine("Person Name: " + personname);
            Console.WriteLine("Person Gennder is: " + gender);
            Console.WriteLine("Student Id is: "+empId);
            Console.WriteLine("Student Marks is: "+salary);
        }   
    }
    class Student : Person {
        public int studId;
        public int marks;

        public void display() { 
            Console.WriteLine("Person Name: " + personname);
            Console.WriteLine("Person Gendeer is: "+gender);
            Console.WriteLine("Student Id is: "+studId);
            Console.WriteLine("Student Marks is: "+marks);
        }   
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s;

            s = new Student();
            s.personname = "Allen";
            s.gender = "Male";
            s.studId = 101;
            s.marks= 70;
            s.display(); 
            System.Console.WriteLine();
            /********* creating object for child class 2 *************/
            Employee emp;
            emp = new Employee();
            emp.personname = "Jones";
            emp.gender = "Male";
            emp.empId = 201;
            emp.salary = 5000;
            emp.display();
            System.Console.ReadKey();

        }
    }
}
