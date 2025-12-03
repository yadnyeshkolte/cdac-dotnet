namespace ExTypeofParams
{
    internal class Program
    {
        static void ReadValueIn(in int data)
        {
            // data++;  //in this the argument value will be passed to the parameter just like
            /// default,but the parameter becomes read only.that means you cannot modify the value of the parameter inside the method
            //if you try to assign , This would cause a compile-time error 
            //the benefit of in parameter in real time projects is it will avoid the accidental changes in the parameter 
            Console.WriteLine($"Inside in method: {data}");
            //data = 300;  not possible


        }

        static void Main(string[] args)
        {
            int w = 50;
            ReadValueIn(in w);
            Console.ReadKey();

        }
    }
}
