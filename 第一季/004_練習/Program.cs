using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_練習
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入數字1");
           int nub1 =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("請輸入數字2");
            int nub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nub1+nub2);

            Console.WriteLine("請輸入數字3");
            int nub3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("請輸入數字4");
            int nub4 = Convert.ToInt32(Console.ReadLine());
            double nub5 = (nub3 + nub4) / 2.0;

            Console.WriteLine(nub5);

             
        }
    }
}
