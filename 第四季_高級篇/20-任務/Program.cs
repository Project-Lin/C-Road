﻿namespace _20_任務
{
    internal class Program
    {
        static void Test()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("A");
            }
            
        }
        static void Test1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("B");
            }

        }
        //連續任務 需要設定參數 因為他要把前面的任務傳遞過來
        static void Test2(Task t)
        {
            Console.WriteLine("接著運行");
        }
        static void Main(string[] args)
        {
            Task task = new Task(Test);
            task.Start();
            //task 是在線程池中執行的 
            task.Wait();  //等待任務完成

            //設定連續任務
            Task task1 = new Task(Test1);

            Task task2 = task1.ContinueWith(Test2);

            task1.Start();
            task2.Wait();


            




        }
    }
}
