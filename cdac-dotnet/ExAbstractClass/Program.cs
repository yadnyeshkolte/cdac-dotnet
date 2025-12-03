using System.Security.Cryptography.X509Certificates;

namespace ExAbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.courseDetails();
            student.courseDuration();
            student.studentDetails();
            student.studentId();
            Console.ReadLine();

            //Cdac c = new Cdac();  --> Not possible


        }
    }

    public abstract class Cdac {
        public void courseDetails() { 
            Console.WriteLine("C-DAC Course Details");
        }
        public void courseDuration() { 
            Console.WriteLine("C-DAC Course Duration is 6 Months");
        }
    }

    public class Student : Cdac {
        public void studentDetails() { 
            Console.WriteLine("Student Details");
        }
        public void studentId() { 
            Console.WriteLine("Student Id is 101");
        }
    }
}
