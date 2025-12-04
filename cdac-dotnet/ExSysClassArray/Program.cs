namespace ExSysClassArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] d = new double[5] { 7, 9, 3, 4, 5 };
            printArray(d);

            d.Reverse();
            printArray(d);

            Array.Sort(d);
            printArray(d);

            Console.WriteLine(Array.IndexOf(d, 9));

            Array.Resize(ref d, 8);
            printArray(d);
            Console.WriteLine(d.Length);

       
        }

        static void printArray(double[] array) {
            foreach (var i in array) { 
                Console.Write(i+" ");
            }
            Console.WriteLine();    
        }
    }
}
