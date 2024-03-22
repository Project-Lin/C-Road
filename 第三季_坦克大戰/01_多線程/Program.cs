using System;
using System.Threading;

namespace _01_多線程
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////線程
            //Thread thread = Thread.CurrentThread;
            //thread.Name = "主執行緒";
            //Console.WriteLine("這是" + thread.Name);

            //創建一個新的線程
            //1. 創建一個Thread類的對象
            //2. 創建一個ThreadStart委託對象
            //3. 通過ThreadStart委託對象創建一個新的線程
            //4. 啟動線程
            ThreadStart Start = new ThreadStart(ChildThreadMethod);
            Thread childread = new Thread(Start);
            childread.Start();

            //Console.WriteLine("主執行緒");
            //while (true)
            //{
            //    Console.WriteLine("主執行緒");
            //    //讓主執行緒 休息1毫秒
            //    Thread.Sleep(1);
            //}

            Thread.Sleep(2000);

            
            isRun = false;
            

            //執行後會發現 主執行 和 child thread 是同時執行 所以有時候主執行緒會先執行 有時候child thread會先執行
        }

        private static bool isRun = true;
        //子線程的方法
        private static void ChildThreadMethod()
        {
            Console.WriteLine("Child Thread running");
            while (isRun)
            {
                Console.WriteLine("Child Thread running");
                Thread.Sleep(1);
            }
        }
    }
}
