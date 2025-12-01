namespace ExAccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.c = 30; //internal member is accessible in the other class at same project
            c1.d = 40; //protected internal member is accessible in the other class at same project
            c1.e = 50; //public member is accessible in the other class at same project
            Console.WriteLine("Value of C is :" + c1.c + "\n Value of D is:" + c1.d + "\n Value of e is :" + c1.e);
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
    class Class1
    {
        private int a;//private member
        protected int b;//protected member
        internal int c;//internal member
        protected internal int d;//protected internal member
        public int e; //public member

        public void Method1()
        {
            a = 10; //private member is accessible in the same class
            b = 20; //protected member is accessible in the same class
            c = 30; //internal member is accessible in the same class
            d = 40; //protected internal member is accessible in the same class
            e = 50; //public member is accessible in the same class
        }
    }

    //child class in the same project
    class Class2 : Class1
    {
        public void Method2()
        {
            b = 20; //protected member is accessible in the child class at same project
            c = 30; //internal member is accessible in the child class at same project
            d = 40; //protected internal member is accessible in the child class at same project
            e = 50; //public member is accessible in the child class at same project
        }

    }
    //other class in the same project
    class Class3
    {
        public void Method3()
        {
            Class1 c1 = new Class1();
            c1.c = 30; //internal member is accessible in the other class at same project
            c1.d = 40; //protected internal member is accessible in the other class at same project
            c1.e = 50; //public member is accessible in the other class at same project
        }
    }

}
