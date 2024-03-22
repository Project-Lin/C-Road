using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串可以當數組  可查詢長度 輸出每個數組資訊
            string name = "abcde";

            Console.WriteLine(name.Length);
            Console.WriteLine(name[2]);

            for(int i =name.Length-1; i >=0 ; i--)
            {
                Console.WriteLine(name[i]);
            }


            foreach(int temp in name)
            {
                Console.WriteLine((char)temp);
            }

            string name1 = "ab,cd,e";

            string[] name2 = name1.Split(',') ;

            foreach(string temp in name2)
            {
                Console.WriteLine(temp);

            }
        }
    }
}
