using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_自增自減運算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            //++ 自身增加1  -- 自身減少1 

            a++;
            a++;
            Console.WriteLine(a);
            a--;
            Console.WriteLine(a);

            //先賦值 OR 先自增
            int b = a++;     //賦值完才自增
            int c = ++a;     //自增完才賦值
            Console.WriteLine(b+":"+c);



        }
    }
}
