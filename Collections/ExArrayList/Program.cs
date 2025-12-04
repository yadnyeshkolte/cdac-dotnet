using System.Collections;

namespace ExArrayList
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList array = new ArrayList() { 10, "add" };

            array.Add(20);
            array.Add("hello");

            Employee emp = new Employee(101, "John");

            array.Add(emp);

            array.Add(new Employee(109, "hi ther"));

            foreach (var i in array)
            {
                Console.WriteLine(i);
            }

        }
    }

    public class Employee
    {
        public int empid;
        public string empname;
        public Employee(int id, string name)
        {
            empid = id;
            empname = name;

        }
    }

}
