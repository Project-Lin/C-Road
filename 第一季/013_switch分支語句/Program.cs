using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_switch分支語句
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch語句 只能判斷相等

            string week =Console.ReadLine();

            switch (week)
            {
                case "星期一":
                    Console.WriteLine("練腿");
                    break;

                case "星期二":
                    Console.WriteLine("練二頭");
                    break;

                case "星期三":
                    Console.WriteLine("練背");
                    break;

                case "星期四":
                    Console.WriteLine("練三頭");
                    break;

                case "星期五":
                    Console.WriteLine("練速度");
                    break;

                case "星期六":
                    Console.WriteLine("有氧");
                    break;

                default:
                    Console.WriteLine("放假");
                    break;
            }






                    int nub = Convert.ToInt32(Console.ReadLine());

            switch (nub) 
            {
                case 1:
                    Console.WriteLine("多喝水");
                    break;

                case 2:
                    Console.WriteLine("麥香紅茶");
                    break;

                case 3:
                    Console.WriteLine("麥香綠茶");
                    break;

                case 4:
                    Console.WriteLine("可樂");
                    break;

                case 5:
                    Console.WriteLine("雪碧");
                    break;

                case 6:
                    Console.WriteLine("紅牛");
                    break;

                default:
                    Console.WriteLine("沒有此商品");
                    break;


            }
        }
    }
}
