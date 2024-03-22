using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_練習題
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入第一個數");
            int nub5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("輸入第二個數");
            int nub6 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("輸入加減乘除");
            string math = Console.ReadLine();


            switch (math)
            {
                case "加":
                case "+":
                    Console.WriteLine(nub5 + nub6);
                    break;

                case "減":
                case "-":
                    Console.WriteLine(nub5 - nub6);
                    break;

                case "乘":
                case "*":
                    Console.WriteLine(nub5 * nub6);
                    break;

                case "除":
                case "/":
                    Console.WriteLine(nub5 / nub6);
                    break;
            }



            Console.WriteLine("輸入第一個數");
            int nub1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("輸入第二個數");
            int nub2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("輸入第三個數");
            int nub3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("輸入第四個數");
            int nub4 = Convert.ToInt32(Console.ReadLine());

            int max = nub1;
            int min = nub1;
            if (nub2 > nub1)
            {
                max = nub2;
            }
            if (nub3 > nub1 && nub3 > max)
            {
                max = nub3;
            }
            if (nub4 > nub1 && nub4 > max)
            {
                max = nub4;
            }

            if (nub2 < nub1)
            {
                min = nub2;
            }
            if (nub3 < nub1 && nub3 < min)
            {
                min = nub3;
            }
            if (nub4 < nub1 && nub4 < min)
            {
                min = nub4;
            }

            Console.WriteLine("最小值:" + min + " 最大值:" + max);


        }
    }
}
