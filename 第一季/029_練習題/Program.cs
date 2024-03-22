using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_練習題
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            char[] b = new char[a.Length];
            char[] c = new char[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];

            }
            int j = 0;
            for(int i = a.Length-1; i >= 0; i--)
            {
                c[i] = b[j];
                j++;
            }
            bool yes = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (b[i] != c[i])
                {
                    Console.WriteLine("不是回文");
                    yes = false;
                    break;
                }
            }
            if (yes)
            {
                Console.WriteLine("是回文");
            }

        }
    }
}
