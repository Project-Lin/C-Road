using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_練習題
{
    class Program
    {
        static void Main(string[] args)
        {

            int all = 0;
            int a = 1;

            //while (a != 0)
            //{
            //    Console.WriteLine("輸入整數");

            //    a = Convert.ToInt32(Console.ReadLine());
            //    all += a;
            //}

            //使用do while 可以少執行第一次判斷
            do
            {
                Console.WriteLine("輸入整數");

                a = Convert.ToInt32(Console.ReadLine());
                all += a;

            } while (a != 0);


            Console.WriteLine(all);

        }
    }
}
