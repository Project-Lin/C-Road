using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034_練習題
{
    class Program
    {
        static int Max(int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                

                if (a[i]>max)
                {
                    max=a[i];
                }

            }
            return max;

        }

        static int[] Getin(int a)
        {
            string b ="1";
            

            for (int i = 2; i <= a; i++)
            {
                
                if (a % i == 0)
                {
                    b +=" "+i ;

                }
                

            }
            string[] arrS = b.Split(' ');
            int[] arri = new int[arrS.Length];
            for (int i = 0; i < arrS.Length; i++)
            {
                arri[i] = Convert.ToInt32(arrS[i]);
            }
            return arri;
        }
        
        static void Main(string[] args)
        {
            //string a = Console.ReadLine();
            //string[] arrS = a.Split(' ');
            //int[] arri = new int[arrS.Length];


            //for (int i = 0; i < arrS.Length; i++)
            //{
            //    arri[i] = Convert.ToInt32(arrS[i]);

            //}
            //int max = Max(arri);
            //Console.WriteLine(max);




            int[] a = Getin(1);

            foreach (int temp in a)
            {
                Console.Write(temp + " ");
            }



        }
    }
}
