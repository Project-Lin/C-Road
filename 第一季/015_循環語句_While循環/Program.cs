using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_循環語句_While循環
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;

            while (n<=100)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                }
                n++;

            }




            int nub = 0;


            //當滿足條件 就執行循環  不滿足則跳出循環
            while (nub<100)
            {
                Console.WriteLine( ++nub);
            }



            //設定兩個數 列出區間的偶數
            Console.WriteLine("輸入第一個數");
            int nub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("輸入第二個數");
            int nub2 = Convert.ToInt32(Console.ReadLine());
            if (nub1 > nub2)
            {
                while (nub2<=nub1)
                {
                    if (nub2 % 2 == 0)
                    {
                        Console.WriteLine(nub2);
                    }
                    nub2++;
                }
            }
            else
            {
                while (nub1 <= nub2)
                {
                    if (nub1 % 2 == 0)
                    {
                        Console.WriteLine(nub1);
                    }
                    nub1++;
                }
            }
        }
    }
}
