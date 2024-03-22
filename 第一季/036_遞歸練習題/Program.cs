using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_遞歸練習題
{
    class Program
    {

        static int F(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n*n+F(n-1);
        }
        static void Main(string[] args)
        {
            //1*1+2*2+...n*n
            //n*n+(n-1)*(n-1)+....

            int i = 1;
            while (F(i) < 2000)
            {
                i++;
            }
            i -= 1;

            Console.WriteLine(F(i));
            Console.WriteLine(i);
        }
        
    }
}
