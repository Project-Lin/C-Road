namespace _04_屬性
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1=new Customer(); 

            //c1.SetAge(1);

            //Console.WriteLine(c1.GetAge());

            c1.Age = 1;
            Console.WriteLine(c1.Age);

            c1.Name = "Test";
            Console.WriteLine(c1.Name);
        }
    }
}
