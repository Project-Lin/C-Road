namespace _19_MyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> a = new MyList<string>();
            a.Add("三");
            a.Add("一");
            a.Add("四");
            a.Add("二");
            
            a.Add("四");
           
            a.Sort();

            MyList<int> b = new MyList<int>();

            b.Add(1);

            b.Add(5);
            b.Add(2);
            b.Add(8);
            b.Add(0);
            b.Sort();
            


            Console.WriteLine(a);
            Console.WriteLine(a.Count());
            Console.WriteLine(a.Capacity());

            Console.WriteLine(b);
        }
    }
}
