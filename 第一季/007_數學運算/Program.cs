using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_數學運算
{
    class Program
    {
        static void Main(string[] args)
        {

            //加減乘除 餘
            int a = 23 + 24;
            int b = 23 - 24;
            int c = 24 * 3;
            int d = 24 / 3;
            int e = 24 % 5;   //餘數 4


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

            //如何分離 個位數 十位數 百位

            int nub = 398;
            int nub1 = nub % 10;  //個位數
            int nub3 = nub / 100; //百位數
            int nub2 = (nub-nub3*100) / 10;  //十位數

            Console.WriteLine("百位數是{2}，十位數是{1}，個位數是{0}", nub1, nub2,nub3);


            int f = 20;
            f += 10;          //f=20+10  30
            Console.WriteLine(f);
            f -= 10;          //f=30-10  20
            Console.WriteLine(f);
            f /= 10;          //f=20/10  2
            Console.WriteLine(f);
            f *= 10;          //f=2*10  20
            Console.WriteLine(f);
            f %= 7;           //f=20%7   6
            Console.WriteLine(f);

        }
    }
}
