﻿namespace _15_線程Thread
{
    internal class Program
    {
        //線程
        private static void Test()
        {
            Console.WriteLine("start");
            Thread.Sleep(1000);
            Console.WriteLine("end");
        }

        //傳遞參數的線程
        static void Donload(object obj)
        {
            string url = obj as string;
            Console.WriteLine(url);

        }

        static void DonloadData(object data)
        {
            Data data1 = (Data)data;
            Console.WriteLine(data1.Name);
            Console.WriteLine(data1.Age);
        }
        public struct Data
        {
            public string Name;
            public int Age;
        }
        static void Main(string[] args)
        {
            //創建線程 Thread(方法名)
            Thread thread = new Thread(Test);
            thread.Start();
            //創建線程 方法可以使用 Lambda 表達式 (Thread.CurrentThread.ManagedThreadId 獲取當前線程ID)
            Thread thread2 = new Thread(() => Console.WriteLine("Child Threaad: " + Thread.CurrentThread.ManagedThreadId));
            thread2.Start();
            Console.WriteLine("Main");

            //傳遞參數的線程 只能傳遞一個參數
            Thread thread1 = new Thread(Donload);
            thread1.Start("http://www.baidu.com");

            //傳遞多個參數 使用結構體
            Data data = new Data();
            data.Name = "檔案";
            data.Age = 18;
            
            Thread thread3 = new Thread(DonloadData);
            thread3.Start(data);

            
        }
    }
}
