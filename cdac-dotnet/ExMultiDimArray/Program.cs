namespace ExMultiDimArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ma = new int[3, 2]
            {
                {1,2},
                {4,5},
                {7,8}
            };

            for (int i =0;i<ma.GetLength(0);i++) {
                for (int j = 0; j < ma.GetLength(1); j++)
                {
                    Console.Write(ma[i,j]+" ");
                }
                Console.WriteLine();
            
            }
            Console.ReadKey();
        }
    }
}
