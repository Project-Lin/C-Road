using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_排序
{
    class Program
    {
        static void Main(string[] args)
        {
            string org = Console.ReadLine();
            string[] arrS = org.Split(' ');
            int[] arrI = new int[arrS.Length];

            for(int i= 0; i < arrS.Length; i++)
            {
                arrI[i] = Convert.ToInt32 (arrS[i]);

            }

            Array.Sort(arrI);
            foreach(int temp in arrI)
            {
                Console.Write(temp + " ");

            }
        }
    }
}
