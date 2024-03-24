namespace A
{
    class Test
    {
        public static void Print()
        {
            Console.WriteLine("A.Test.Print()");
        }
    }
}

namespace B
{
    class Test
    {
        public static void Print()
        {
            Console.WriteLine("B.Test.Print()");
        }
    }
}

class Test
{
    static void Main()
    {
        A.Test.Print();
        B.Test.Print();
    }
}