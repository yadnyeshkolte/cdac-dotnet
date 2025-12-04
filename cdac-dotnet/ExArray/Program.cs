namespace ExArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks;

            marks = new int[7]; 

            marks[0] = 4;
            marks[1] = 5;
            marks[2] = 6;
            marks[3] = 7;
            marks[4] = 8;
            marks[5] = 9;
            marks[6] = 10;


            for (int i=0;i<marks.Length;i++) {
                Console.Write(marks[i]+" ");
            
            }
            Console.ReadKey();
        }
    }
}
