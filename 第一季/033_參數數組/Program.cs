using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_參數數組
{
    class Program
    {
        static int Add(params int[] a)
        {
            int ans = 0;
            foreach(int i in a)
            {
                ans += i;

            }
            return ans;

        }  
        static void Main(string[] args)
        {
            int c = Add(3, 6, 7);
            Console.WriteLine(c);

        }
    }
}
