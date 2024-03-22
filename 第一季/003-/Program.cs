using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_變量
{
    class Program
    {
        static void Main(string[] args)
        {
            //創建變量
            //儲存數據的容器 容器名為age 類型:int(整數類型)
            int age;
            //往容器放數值 賦值
            age = 10;

            double hight = 1.2;   //類型:小數
            char sex = 'd';       //''字符  ""字符串

            Console.WriteLine(sex);


            int a = 3, b = 8;
            Console.WriteLine(a + b); //11
            Console.WriteLine("a + b");  //a+b
            Console.WriteLine(a + "+" + b); //3+8
            Console.WriteLine("a+b" + a + b); //a+b38
            Console.WriteLine("a+b" + (a + b)); //a+b11

        }
    }
}
