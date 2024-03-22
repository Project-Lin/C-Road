using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_2_練習題
{
    class Program
    {
        static void Main(string[] args)
        {
            //輸入一個整數A，和一個整數N，計算A的N次方。

            //Console.WriteLine("輸入整數");

            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("輸入平方次數");

            //int n = Convert.ToInt32(Console.ReadLine());

            //int ans = 1;

            //for (int c = 0; c < n; c++)
            //{
            //    ans *= a;

            //}
            //Console.WriteLine("{0}的{1}次方={2}", a, n, ans);




            ////輸入整數N 輸出N的階乘 (1*2*3 .... *n )

            //Console.WriteLine("輸入整數");

            //int n = Convert.ToInt32(Console.ReadLine());
            //int ans = 1;

            //for (int c = 1; c < n; c++)
            //{
            //    ans *= (c + 1);

            //}
            //Console.WriteLine(ans);


            ////輸入q和n，求1+q一次方+q二次方 ...+q n次方

            //Console.WriteLine("輸入整數 q");

            //int q = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("輸入整數n");

            //int n = Convert.ToInt32(Console.ReadLine());
            //int temp = 1;
            //int ans = 1;

            //for(int i = 0; i < n; i++)
            //{
            //    temp *= q;
            //    ans += temp;


            //}
            //Console.WriteLine("ans:"+ans);



            double SN = 1;
            double temp = 0;
            int i = 1;
            int k = Convert.ToInt32(Console.ReadLine());
            if (k >= 1 && k <= 15)
            {
                for( ; temp <= k; i++)
                {
                    temp +=(SN / i);


                }
                Console.WriteLine(i-1);

            }

        }
    }
}
