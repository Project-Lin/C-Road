namespace _09_多播委託
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action a = Test;
            a += Test2;
            a(); //Test Test2

            a -= Test;
            a(); //Test2
        }

        private static void Test()
        {
            Console.WriteLine("Test");
        }

        private static void Test2()
        {
            Console.WriteLine("Test2");
        }
    }
}
