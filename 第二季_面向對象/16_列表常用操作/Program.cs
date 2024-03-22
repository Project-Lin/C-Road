namespace _16_列表常用操作
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8 ,999,777,999};


            Console.WriteLine(list.IndexOf(999));
            Console.WriteLine(list.LastIndexOf(999));
            foreach (int i in list)
            {
                Console.Write(i+" ");
            }

        }
    }
}
