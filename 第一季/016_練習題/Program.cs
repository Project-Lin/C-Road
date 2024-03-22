using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_練習題
{
    class Program
    {
        static void Main(string[] args)
        {
            //3n+1 問題: 輸入任意大於1的數 ， 若為偶數就 /2 ，奇數則 *3+1 ，最終都會得到1
            //得到過程次數

            Console.WriteLine("輸入一個數");
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            while (a!=1)
            {
                if (a % 2 == 0)
                {
                    a /= 2;

                    Console.WriteLine(a);
                }

                else
                {
                    a = a * 3 + 1;

                    Console.WriteLine(a);
                }

                count++;

            }

            Console.WriteLine("次數:"+count);
        }
    }
}
