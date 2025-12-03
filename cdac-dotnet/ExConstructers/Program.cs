namespace ExConstructers
{
    /* public class Sample
     {
         int i;
         public Sample(int x)
         {
             i = x;
             Console.WriteLine("Constructor is called :" +x );
         }
         public Sample(Sample obj)
         {
             i = obj.i;
         }
         public void Display()
         {
             Console.WriteLine("value of i is : " + i);
         }
     }
     */

    internal class Program
    {
        // int i; bool b;
        static Program()
        {

            Console.WriteLine("Static constructor is executed"); // controls first goes to this and executes
        }
        public Program(int i)
        {
            Console.WriteLine("Instance Constructor " + i);
        }
        public string get_detail(string name, int id)
        {
            return "Name: " + name + " id: " + id;
        }
        static void Main(string[] args)
        {
            /* Program p = new Program();
              Console.WriteLine(p.i);
              Console.WriteLine(p.b);
              Console.ReadLine();*/


            /*Sample s = new Sample(10);
            Sample s1 = new Sample(20);
            Sample s2 = new Sample(30);
            s.Display();
            s1.Display();
            Console.ReadLine();*/

            /*
             Sample s = new Sample(30);
             s.Display();
             Sample s1 = new Sample(s);
             s1.Display();
             Console.ReadLine();
            */
            // Here Both Static and instance constructors are invoked for first instance
            Program obj = new Program(1);

            Console.WriteLine(obj.get_detail("C-DAC", 1));
            Program obj1 = new Program(2);
            Console.WriteLine(
             obj1.get_detail("C-DAC Bangalore", 2));
            Console.ReadKey();

        }
    }

}
