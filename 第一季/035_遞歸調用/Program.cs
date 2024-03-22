using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_遞歸調用
{
    class Program
    {
        static long F(long a)
        {
            if (a == 1)
            {
                return 1;
            }
            return a * F(a - 1);

        }

        static long G(long n)
        {
            if (n == 1)
            {
                return 1;
            }


            return G(n-1) + F(n);
        }
        static void Main(string[] args)
        {
            ////10!  = 10*9*8*7 .... *1

            //int ans = 1;
            //for(int i =1; i < 11; i++)
            //{
            //    ans *= i;

            //}
            //Console.WriteLine(ans);

            Console.WriteLine(F(10));


            long ans = 0;


            for (int j = 1; j < 21; j++)
            {
                long temp = 1;
                for (int i = 1; i < j + 1; i++)
                {
                    temp *= i;

                }

                ans += temp;
            }


            Console.WriteLine(ans);
            Console.WriteLine(G(20));
        }
    }
}
