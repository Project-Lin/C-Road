using System;  //引入命名空間
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個小數：");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double number))
            {
                double roundedNumber = Math.Round(number, 1);
                Console.WriteLine($"四捨五入後的結果為：{roundedNumber}");
            }
            else
            {
                Console.WriteLine("輸入的值不是有效的數字。");
            }
        }
    }
}
