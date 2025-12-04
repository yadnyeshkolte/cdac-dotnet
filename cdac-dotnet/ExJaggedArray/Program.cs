namespace ExJaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jagged array is array of arrays
            //That means it is an array fundamentally.And in each row you will have another array.
            //But the difference between the multidimensional and jagged array is that in case of multidimensional,
            //the number of columns for all the rows must be the same.
            //But in case of jagged arrays, the number of columns.That means the number of values for each row can be different.

            int[][] ja = new int[5][];

            ja[0] = new int[6] {0,1,2,3,4,5};
            ja[1] = new int[2] {4, 5};
            ja[2] = new int[3] {5, 6, 7};
            ja[3] = new int[4] {6, 7, 3, 2};
            ja[4] = new int[5] { 1, 2, 3, 4, 5 };

            for (int i=0;i<ja.Length;i++) {
                for (int j = 0; j < ja[i].Length; j++) {
                    Console.Write(ja[i][j]+" ");
                }
                Console.WriteLine();
            
            }

        }
    }
}
