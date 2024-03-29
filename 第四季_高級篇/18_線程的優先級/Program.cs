namespace _18_線程的優先級
{
    internal class Program
    {
        static void ThreadMainA()
        {
            while (true)
            {
                Console.WriteLine("執行緒開始");
                Thread.Sleep(1000);
            }
        }
        static void ThreadMainB()
        {
            while (true)
            {
                Console.WriteLine("執行緒開始");
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            
            Thread threadA = new Thread(ThreadMainA);
            Thread threadB = new Thread(ThreadMainB);
            //設定線程的優先級 有以下幾種 : highest, aboveNormal, normal, belowNormal, lowest
            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Lowest;
            threadA.Start();
            threadB.Start();

        }
    }
}
