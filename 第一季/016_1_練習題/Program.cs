using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_1_練習題
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2006;
            int peple = 80000;

            while (peple<= 200000)
            {
                year++;
                peple = peple+( peple * 25/100);
                Console.WriteLine(year + " 年"+peple+" 人");

            }
            Console.WriteLine(year+"年");
        }
    }
}
