using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_變量研究
{
    class Program
    {
        static void Main(string[] args)
        {
            //變量互換 (a b 值互換)
            int a = 5, b = 10;
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a);
            Console.WriteLine(b);

            //不使用temp

            int c = 5, d = 10;
            c = c + d;
            d = c - d;
            c = c - d;

            Console.WriteLine(c);
            Console.WriteLine(d);


            //變量格式化輸出

            int e = 44, f = 59;
            Console.WriteLine(e + "+"+f+"="+(e + f));

            //        使用大括號取用後面的值    0, 1,   2  (較方便閱讀)

            Console.WriteLine("{0}+{1}={2}", e, f, e + f); 


        }
    }
}
