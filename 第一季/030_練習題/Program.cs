using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_練習題
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = Console.ReadLine();
            //string[] arrs = a.Split(' ');
            //int[] arri = new int[arrs.Length];

            //for(int i = 0; i < arrs.Length; i++)
            //{
            //    arri[i] = Convert.ToInt32(arrs[i]);

            //}
            //int max = 1;
            //int count = 1;
            //for (int i = 0; i < arrs.Length-1; i++)
            //{
            //    if (arri[i+1] > arri[i])
            //    {
            //        count++;
            //    }
            //    else
            //    {

            //        if (count > max)
            //        {
            //            max = count;
            //        }
            //        count = 1;
            //    }
            //}
            //if (count > max)
            //{
            //    max = count;
            //}
            //Console.WriteLine(count);


            //string a = Console.ReadLine();
            //string[] arrs = a.Split(' ');
            //int[] arri = new int[arrs.Length];

            //for (int i = 0; i < arrs.Length; i++)
            //{
            //    arri[i] = Convert.ToInt32(arrs[i]);
            //}

            //int ans = 1;



            //for (int j = 0; j < 2 ; j++)
            //{

            //    for (int i = 0; i < arrs.Length - 1-j; i++)
            //    {

            //        if (arri[i] > arri[i + 1])
            //        {
            //            int temp = arri[i];
            //            arri[i] = arri[i + 1];
            //            arri[i + 1] = temp;
            //            ans = arri[i + 1];
            //        }


            //    }

            //}



            //Console.WriteLine(ans);



            //string a = Console.ReadLine();
            //char chack = ' ';
            //char chack1 = ' ';
            //char ans =' ' ;
            //int same = 0;


            //for(int i = 0; i < a.Length; i++)
            //{
            //    chack = a[i];

            //    for (int j = 0; j < a.Length; j++)
            //    {
            //        chack1= a[j];
            //        if (chack == chack1)
            //        {
            //            same++;

            //        }

            //    }
            //    if (same == 1)
            //    {

            //        break;
            //    }
            //    else
            //    {
            //        same = 0;
            //    }


            //}
            //if (same != 0)
            //{
            //    Console.WriteLine(chack);

            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}




            string a = Console.ReadLine();
            int[] all = new int[26];

            for (int i = 0; i < a.Length; i++)
            {
                all[(a[i] - 'a')] += 1;

            }

            char ans = ' ';

            for (int i = 0; i < a.Length; i++)
            {
                if(all[(a[i] - 'a')] == 1)
                {
                    ans = a[i];
                    break;
                }
            }
            if(ans==' ')
            {
                Console.WriteLine("no");

            }
            else
            {
                Console.WriteLine(ans);

            }







        }
    }
}
