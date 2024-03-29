namespace _07_Func委託
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func 委託是一個有返回值的泛型委託
            Func<string> a = Print;
            Console.WriteLine(a());  //無參

            //Func<int,float,string> 委託的泛型參數是int,float 類型 返回值寫在最後是string
            Func<int,float,string> b = PrintInt;
            Console.WriteLine(b(10,20.0f));  //10+20
        }

        private static string Print()
        {
            return "無參";
        }

        private static string PrintInt(int x ,float y)
        {
            return $"{x}+{y}";
        }
    }
}
