namespace _15_列表
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(10) { 123,241,4566 };
                                     // (初始容量) 0   1    2
            list.Add(1);
            list.Add(2);
            list[2] = 100;

            Console.WriteLine(list[3]);

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

        }
    }
}
