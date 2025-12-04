namespace ExArrayLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };

            foreach (int i in a) {
                Console.Write(i+" ");
            }
        }
    }
}
