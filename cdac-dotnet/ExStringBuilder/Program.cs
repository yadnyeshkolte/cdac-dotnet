using System.Text;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ExStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i=0;i<100000;i++) {
                s = s + i;
            }
            sw.Stop();

            StringBuilder sb = new StringBuilder();
            Stopwatch sw1 = new Stopwatch();    
            sw1.Start();

            for (int i=0;i<100000;i++) {
                sb.Append(i);
            }
            sw1.Stop();

            Console.WriteLine("Time for normal string: "+ sw.ElapsedMilliseconds);

            Console.WriteLine("Time for string builder: "+sw1.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
