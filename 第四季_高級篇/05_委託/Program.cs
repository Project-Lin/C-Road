﻿namespace _05_委託
{
    internal class Program
    {
        // 定義委託 重點在於返回值和參數
        delegate void IntDelegate(int x);
        delegate double DoubleDelegate(double a ,double b);
        static void Main(string[] args)
        {
            // 委託的實例化
            IntDelegate a = new IntDelegate(PrintInt);
            a(10);

            //將方法委託給委託對象 就像把快遞 給 快遞員 讓快遞員執行送快遞的工作
            DoubleDelegate b = Add;
            Console.WriteLine(b(1.1, 2.2)); //3.3
            b=Sub;
            Console.WriteLine(b(1.1, 2.2)); //-1.1


            //通常委託會先設定成空 還不確定要送去哪的狀態
            DoubleDelegate c = null;
            
            //保護機制 如果委託不是空的，才執行委託
            if (c != null)
            {
                Console.WriteLine(c(1.1, 2.2));
            }


            //委託數組
            DoubleDelegate[] ds = { Add, Sub };

            foreach (var d in ds)
            {
                Console.WriteLine(d(1.1, 2.2));
            }

        }

        private static void PrintInt(int x)
        {
            Console.WriteLine(x);
        }

        private static double Add(double a, double b)
        {
            return a + b;
        }

        private static double Sub(double a, double b)
        {
            return a - b;
        }
    }
}
