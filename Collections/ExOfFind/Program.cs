namespace ExOfFind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> marks = new List<int>() { 23, 45, 67, 89, 12, 90, 34, 56 };

            bool b = marks.Exists(m => m > 55);

            if (b)
            {
                Console.WriteLine(b);
            }
            else {
                if (b == true)
                {
                    Console.WriteLine("Student is failed in one or more subjects");

                }
                else
                {
                    Console.WriteLine("Student is Pass");

                }
                //Find:Get marks of first failed subject
                int firstfailedMarks = marks.Find(m => m < 35);
                Console.WriteLine("First Failed marks :" + firstfailedMarks);

                Console.ReadKey();

            }

        }
    }
}
