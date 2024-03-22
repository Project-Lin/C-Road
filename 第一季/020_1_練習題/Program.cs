using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_1_練習題
{
    class Program
    {
        static void Main(string[] args)
        {
           /*球從輸入高度落下，每次落下反彈原來高度的一半，再落下
            * 1.求第十次反彈時的高度  2.第十次落地時，經過了多少米
            */

            double high = Convert.ToInt32(Console.ReadLine());
            double all = high;

            for (int a=0;a<10 ;a++)
            {
                all +=2*(high /= 2);

               

            }
            Console.WriteLine("經過了{0}米",all);
            Console.WriteLine("第10次反彈{0}米",high);

        }
    }
}
