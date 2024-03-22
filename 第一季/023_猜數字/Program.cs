using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_猜數字
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();

            
            int a = rd.Next(1, 101);
            int b = 0;
            Console.WriteLine("猜一個數");

            b = Convert.ToInt32(Console.ReadLine());

            while (a != b)
            {
                
                if (a > b)
                {
                    Console.WriteLine("太小");
 
                }

                if (a < b)
                {
                    Console.WriteLine("太大");

                }
                b = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("答對");
        }
    }
}
