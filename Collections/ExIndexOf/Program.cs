namespace ExIndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //collection
            List<int> mylist = new List<int>() { 10, 20, 30, 50, 60 };

            //search for 40
            int n = mylist.IndexOf(50);
            Console.WriteLine("50 is found at " + n);

            //search for 80
            int n2 = mylist.IndexOf(60);
            Console.WriteLine("60 found at " + n2);

            Console.ReadKey();

            //collection for binary search
            //the binary search requires a collection ,which is already sorted.
            //On unsorted collections, binary search is not possible.
            //It directly goes to the middle of the collection(collection size / 2),
            //and checks that item is less than / greater than the search value.
            //If that item is greater than the search value, it searches only in the first half of the collection.
            //If that item is less than the search value, it searches only in the second half of the array.
            List<int> mylist2 = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int n4 = mylist2.BinarySearch(80);
            Console.WriteLine("Binary search of 80 is :" + n4);

            Console.ReadKey();
        }
    }
}
