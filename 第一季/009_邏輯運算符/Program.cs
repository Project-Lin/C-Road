using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_邏輯運算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //   &&符合兩個條件     ||符合其中一個      !非 (相反結果

            bool a = (2 > 4) && (9 > 6);
            bool b = (4 > 2) && (9 > 6);
            Console.WriteLine(a);
            Console.WriteLine(b);
            
            bool c = (2 > 4) || (9 > 6);
            bool d = (2 > 4) || (9 < 6);
            Console.WriteLine(c);
            Console.WriteLine(d);

            bool e = !(9 > 6);
            Console.WriteLine(e);


            //練習 
            Console.WriteLine("請輸入年齡");
            int f = Convert.ToInt32( Console.ReadLine());
            bool teen = (f >= 18) && (f <= 80);
            if (teen==true) Console.WriteLine("你還沒老");
            if (teen==false) Console.WriteLine("你老");




        }
    }
}
