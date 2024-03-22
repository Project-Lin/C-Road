using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_2_練習題
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入數字");
            int nub = Convert.ToInt32(Console.ReadLine());
            int star = 1;

            while (star < nub+1)
            {
                Console.Write(star+" ");
                star++;
                

            }



            Console.WriteLine("輸入人數");
            int people = Convert.ToInt32(Console.ReadLine());
            double temp = 0;
            int count = 1;

            while (people > 0)
            {

                Console.WriteLine("第" + count + "個人幾歲?");

                //int age1 = Convert.ToInt32(Console.ReadLine());
                //temp += age1;
                temp += Convert.ToInt32(Console.ReadLine());

                people--;
                count++;

            }

            temp /= (count - 1);

            //temp=(int)(temp * 100);
            //temp = (double)(temp / 100);
            temp = ((int)(temp * 100)) / 100.0;



            Console.WriteLine("平均年齡為:"+temp);


        }
    }
}
