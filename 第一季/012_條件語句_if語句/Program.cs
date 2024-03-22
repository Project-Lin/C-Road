using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_條件語句_if語句
{
    class Program
    {
        static void Main(string[] args)
        {
            double m = Convert.ToDouble(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());

            if (k == 0)
            {
                m = (int)m;
                Console.WriteLine(m);
            }

            else { double temp = ((int)((m + 0.05) * 10)) / 10.0;
                Console.WriteLine(temp);
            }

            //if (k == 1 && (m * 100 % 10) >= 5)
            //{
            //    m = m * 10 + 1;
            //    m = (int)m;
            //    double temp = m / 10.0;

            //    console.writeline(temp);
            //}
            //else if (k == 1 && (m * 100 % 10) < 5)
            //{
            //    m = m * 10;
            //    m = (int)m;
            //    double temp = m / 10.0;

            //    console.writeline(temp);
            //}




            int nub5 = Convert.ToInt32(Console.ReadLine());
            int nub6 = Convert.ToInt32(Console.ReadLine());
            int nub7 = Convert.ToInt32(Console.ReadLine());

            if (nub5 > nub6 && nub5 > nub7 && nub6 > nub7) { Console.WriteLine("" + nub7 + nub6 + nub5); }
            if (nub5 > nub6 && nub5 > nub7 && nub7 > nub6) { Console.WriteLine("" + nub6 + nub7 + nub5); }
            if (nub6 > nub5 && nub6 > nub7 && nub5 > nub7) { Console.WriteLine("" + nub7 + nub5 + nub6); }
            if (nub6 > nub5 && nub6 > nub7 && nub7 > nub5) { Console.WriteLine("" + nub5 + nub7 + nub6); }
            if (nub7 > nub5 && nub7 > nub6 && nub5 > nub6) { Console.WriteLine("" + nub6 + nub5 + nub7); }
            if (nub7 > nub5 && nub7 > nub6 && nub6 > nub5) { Console.WriteLine("" + nub5 + nub6 + nub7); }







            Console.WriteLine("輸入性別(男M  女F)");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("數字");
            int nub4 = Convert.ToInt32(Console.ReadLine());

            if (gender == 'M' && nub4 % 2 == 0) { Console.WriteLine("1000M,伏地挺身"); }
            else if (gender == 'M' && nub4 % 2 != 0) { Console.WriteLine("1000M,跳遠"); }
            else if (gender == 'F' && nub4 % 2 != 0) { Console.WriteLine("800M,跳繩"); }
            else if (gender == 'M' && nub4 % 2 == 0) { Console.WriteLine("800M,仰臥起坐"); }






            //輸入兩個大寫英文 由小到大排序


            Console.WriteLine("輸入第一個大寫英文字母");
            char a1 =Convert.ToChar( Console.ReadLine());
            Console.WriteLine("輸入第二個大寫英文字母");
            char a2 = Convert.ToChar(Console.ReadLine());

           if(Convert.ToInt32(a1)< Convert.ToInt32(a2)) { Console.WriteLine(a1 + "." +a2); }
            else { Console.WriteLine(a2 + "." + a1); }

           //或使用格式化輸出寫法
            if (Convert.ToInt32(a1) < Convert.ToInt32(a2)) { Console.WriteLine("{0}.{1}",a1,a2); }
            else { Console.WriteLine("{0}.{1}", a2, a1); }



         //輸入三個數 找出最大值 並平方輸出


            Console.WriteLine("輸入第一個數");
            int nub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("輸入第二個數");
            int nub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("輸入第三個數");
            int nub3 = Convert.ToInt32(Console.ReadLine());
            if (nub1 > nub2 && nub1 > nub3) { Console.WriteLine(nub1 * nub1); }
            if (nub2 > nub1 && nub2 > nub3) { Console.WriteLine(nub2 * nub2); }
            if (nub3 > nub2 && nub3 > nub1) { Console.WriteLine(nub3 * nub3); }


         //輸入x和y值 判斷位於哪個象限
            Console.WriteLine("輸入X");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("輸入y");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0) { Console.WriteLine("第一象限"); }
            else if (y == 0 && x != 0) { Console.WriteLine("y軸上"); }
            else if (x == 0 && y != 0) { Console.WriteLine("x軸上"); }
            else if (x == 0 && y == 0) { Console.WriteLine("原點"); }
            else if (x > y && x > 0) { Console.WriteLine("第四象限"); }
            else if (x < y && y > 0) { Console.WriteLine("第二象限"); }
            else  { Console.WriteLine("第三象限"); }





         //輸入成績 依照分數區間給出評級

            //else if 多重判斷
            Console.WriteLine("輸入成績");
            int sc = Convert.ToInt32(Console.ReadLine());
            if (sc >= 90) { Console.WriteLine("評分為A"); }

            else if (sc >= 70) { Console.WriteLine("評分為B"); }

            else if (sc >= 60) {Console.WriteLine("評分為C"); }

            else {   Console.WriteLine("評分為D");  }




         //輸入年齡 需要18~30歲才能參加活動 並且年齡是

            Console.WriteLine("輸入年齡");
            int age1 = Convert.ToInt32(Console.ReadLine());

            bool isok = age1 >= 18 && age1 <= 30;

            if (isok) {
               
                bool isok2 = age1 % 2 != 0;

                if (isok2) { Console.WriteLine("有獎"); }
                else { Console.WriteLine("滾"); }
            }
            else { Console.WriteLine("滾"); }



        //判斷奇數偶數

            Console.WriteLine("輸入數字");
            int nub = Convert.ToInt32(Console.ReadLine());
            if(nub%2==0) { Console.WriteLine("這是偶數"); }
            else { Console.WriteLine("這是奇數"); }



        //16歲以上才通過


            Console.WriteLine("輸入年齡");
            int age = Convert.ToInt32(Console.ReadLine());

              //滿足條件會執行
            if (age <= 16) { Console.WriteLine("通過"); }

            else { Console.WriteLine("不通過"); }

        }
    }
}
