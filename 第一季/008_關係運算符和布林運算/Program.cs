using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_關係運算符和布林運算
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;        //是 滿足條件 1

            bool b = false;       //否 不滿足   0

            Console.WriteLine(a);
            Console.WriteLine(b);

            //關係運算符 比較兩個常量或變量

            bool c = 45 == 67;   // = = 等於
            bool d = 45 < 67;   //小於
            bool e = 45 <= 67;   //小於或等於
            bool f = 45 > 67;   //大於
            bool g = 45 >= 67;   // 大於或等於
            bool h = 45 != 67;   // ! =  不等於
 
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);

          



        }
    }
}
