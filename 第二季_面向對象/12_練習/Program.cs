namespace _12_練習
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B b=new B();
            A a=new A();
            a.Fun2(b);
            b.Fun2(a);
        }
    }
}
