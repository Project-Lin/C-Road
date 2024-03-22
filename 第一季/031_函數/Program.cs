using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_函數
{
    class Program
    {

        //方法的定義 ( 返回值 方法值 (參數) )
        static bool VerifyUsername()
        {
            Console.WriteLine("123123");

            return true;
        }

        static int Add(int a,int b)
        {
            int c = a + b;
            return c;
        }

        //主函數 入口函數  主方法 入口方法
        static void Main(string[] args)
        {
            //調用方法
            VerifyUsername();
            int a = Add(3, 15);

            Console.WriteLine(a);
        }
    }
}
