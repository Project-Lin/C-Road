using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_變量的作用域
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                //大括號內的變量就是局部變量
            {
                int a = 100;
                Console.WriteLine(a);

            }

            a=10  //在括號外(不同作用域)就讀取不到
        }
    }
}
