using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_練習題
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入數學成績");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("輸入英文成績");
            int english = Convert.ToInt32(Console.ReadLine());
            bool f = math >= 90 && english >= 90;
            if (f == true) Console.WriteLine("有獎");
            if (f == false) Console.WriteLine("真爛");

            //輸入一個整數三位數 按數字倒反順序輸出

            int a = Convert.ToInt32(Console.ReadLine());
            int nub1 = a % 10;
            int nub2 = a / 10 % 10;
            int nub3 = a / 100;
            Console.WriteLine(nub1 * 100 + nub2 * 10 + nub3);

            Console.WriteLine(""+nub1+nub2+nub3);


            //輸入一個五位數 提取千位和十位 組成兩位數 轉換為字符

            int code = Convert.ToInt32(Console.ReadLine());
            int nub4 = code / 10 % 10;
            int nub5 = code / 1000 % 10;

            Console.WriteLine(Convert.ToChar(nub5 * 10 + nub4));






        }
    }
}
