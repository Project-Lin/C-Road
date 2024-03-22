using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_for循環
{
    class Program
    {
        static void Main(string[] args)
        {
            ////    初始化   條件  執行
            //for(int a =1 ;a<11 ;a++)
            //{
            //    Console.WriteLine(a);
            //}

            //for(int b = 0; b < 20; b++)
            //{
            //    Console.Write("*");

            //}

            //int temp = 0;



            //for (int c = 1; c < 101; c++)
            //{


            //    temp += c;



            //}
            //Console.WriteLine(temp);

            //for (int i = 1;  i< 101; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);

            //    }
            //}


            ////////////////////////////////////////////

            //Console.WriteLine("輸入第一個數");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("輸入第二個數");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int all = 0;

            //if (a > b)
            //{


            //    for (int g = b; g < a+1; g++)
            //    {
            //        if (g % 17 == 0)
            //        {
            //            all += g;


            //        }
            //    }
            //    Console.WriteLine(all);
            //}
            //else
            //{


            //    for (int g = a; g < b+1; g++)
            //    {
            //        if (g % 17 == 0)
            //        {
            //            all += g;


            //        }
            //    }
            //    Console.WriteLine(all);
            //}



            Console.WriteLine("輸入第一個數");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("輸入第二個數");
            int b = Convert.ToInt32(Console.ReadLine());
           

            for (int time = a; time < b + 1; time++)
            {
                if (time % 2 == 0)
                {
                    Console.Write(time + " ");

                }
            }
            Console.WriteLine();
            for (int time = a; time < b + 1; time++)
            {
                if (time % 2 != 0)
                {
                    Console.Write(time + " ");

                }
            }
        }
    }
}
