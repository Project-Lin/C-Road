using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_5_練習題
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string ans = "";
            int count = 0;
            bool b = false;


            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0&&count<=3)
                {
                    ans += i+" ";
                    count++;

                }

            }
            if (count == 2)
            {
                b=true;

            }

            Console.WriteLine(b);

        }
    }
}
