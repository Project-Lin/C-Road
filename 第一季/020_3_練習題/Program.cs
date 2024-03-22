using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_3_練習題
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("多少億人");
            //double people = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("多少年");
            //int year = Convert.ToInt32(Console.ReadLine());
            //double ans = people;

            //for (int i = 0; i < year;i++)
            //{
            //    ans *= 1.001;


            //}

            //Console.WriteLine("{0}億人",ans);


            // Console.WriteLine("幾%複合年利率");
            //double r = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("投多少錢");
            // double m = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("放幾年");
            // int y = Convert.ToInt32(Console.ReadLine());

            // r /= 100;

            // for(int i =0; i < y; i++)
            // {
            //     m *= (r+1);

            // }
            // Console.WriteLine((int)m);







            //for (int a = 100; a < 1000; a++)
            //{
            //    int b = a % 10;
            //    int c = a / 10 % 10;
            //    int d = a / 100;

            //    if (a == b * b * b + c * c * c + d * d * d)
            //    {
            //        Console.WriteLine(a);

            //    }

            //}



            //Console.WriteLine("輸入小於1000000的正整數");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int temp = 0;
            //int ans = 0 ;
            //int c = 1;


            //if (a < 1000000 && a > 0)
            //{
            //   for(int i=0; i<7;i++)
            //    {
            //        temp = a % 10;
            //        if (temp != 0)
            //        {
            //            ans += temp * c;
            //            c *= 10;

            //        }

            //        a /= 10;
            //    }
            //    Console.WriteLine(ans);

            //}
            //else
            //{
            //    Console.WriteLine("不符合規則");
            //}



            //Console.WriteLine("輸入正整數");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int temp = 0;

            //int ans = 0;
            //for (; a>=1;)//2300
            //{
            //    temp = a % 10;

            //    ans += temp ;
            //    if (a > 10)
            //    {
            //        ans *= 10;

            //    }
            //    a /= 10;

            //}
            //Console.WriteLine(ans);



            Console.WriteLine("輸入小於1000000的正整數");
            int a = Convert.ToInt32(Console.ReadLine());
            int org = a;
            int temp = 0;
            int chack = 0;

            //先加再乘 就需要判斷需不需要乘10 若是個位數則不用乘
            while (a>=1)
            {
                temp = a % 10;
                chack += temp;
                if (a > 10)
                {
                    chack *= 10;
                }
                a /= 10;
            }
            if (chack == org)
            {
                Console.WriteLine("Yes");

            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine(chack);


            //先乘10再加個位數 就不用判斷
            while (a >= 1)
            {
                temp = a % 10;
                chack *= 10;
                chack += temp;
               
                
              
                a /= 10;
            }
            if (chack == org)
            {
                Console.WriteLine("Yes");

            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine(chack);
        }
    }
}
