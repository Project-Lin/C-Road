using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_字符類型
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符 a 對應整數97 可參考 ASCII 
            char a = 'a' ;

            int b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            //字符轉整數可以直接轉換類型 但整數轉字符會報錯 需要使用(char)強制轉換為字符 
            int c = 97;
            char d = (char)c;
            Console.WriteLine(c);
            Console.WriteLine(d);

            //字符1 對應整數 為 49
            char e = '1' ;
            int f = e;
            Console.WriteLine(e);
            Console.WriteLine(f);

            // @將後面的轉義字符( \ )失效
            Console.WriteLine("c:a\\b\\c");
            Console.WriteLine(@"c:a\b\c");

            //string 字符串類型  字符串相加 就是兩個組合在一起 沒有數學計算
            string str = "projectlin";
            string str2 = "123";
            Console.WriteLine(str + str2);

            //讀取數據 輸入數據 (字符
            Console.WriteLine("請輸入文字");
            string impot = Console.ReadLine();
            Console.WriteLine(impot + '-');


            //字符轉換為整數 使用convert.toint32 並新建一個整數容器存儲 (整數才能做數學運算
            Console.WriteLine("請輸入數字");
            string impotint = Console.ReadLine();
            int intimport = Convert.ToInt32(impotint);
            Console.WriteLine(impotint + (1+intimport));


            //輸入整數 簡寫方式
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( g+1);

        }
    }
}
