using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_數組
{
    class Program
    {
        static void Main(string[] args)
        {
            //聲明int類型的數組
            int[] ages = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //             0  1  2  3  4  5  6  7

            Console.WriteLine(ages[4]);
            Console.WriteLine(ages.Length);
                              //數組長度

            int[] a = new int[10];


            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(ages[i]);
            }

            foreach(int temp in a)
            {
                Console.WriteLine(temp);
            }







        }
    }
}
