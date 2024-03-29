namespace _10_匿名方法和Lambda表達式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> a = delegate (int x, int y)
            {
                return x + y;
            };

            Console.WriteLine(a(10, 20));  //30


            //Lambda表達式

            //省略 delegate 和 參數類型 int
            //Func<參數,參數,返回值> 委託名稱 = (參數1,參數2) => { return 運算式; };
            Func<int, int, int> b = (x, y) => { return x + y; };

            //如果只有一條語句 可以省略{} 和 return
            Func<int, int, int> c = (x, y) => x + y;


            Console.WriteLine(b(10, 20));  //30
            Console.WriteLine(c(10, 20));  //30
        }



    }
}
