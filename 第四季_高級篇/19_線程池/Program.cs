namespace _19_線程池
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Download);
            }
            
            //線程池是後台執行緒 所以主線程要等一下 不然會直接結束
            Thread.Sleep(5000);
        }

        static void Download(object state)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("下載開始"+Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(100);
            }
            
        }
    }
}
