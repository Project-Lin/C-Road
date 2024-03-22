using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_循環嵌套
{
    class Program
    {
        static void Main(string[] args)
        {

            //int n = Convert.ToInt32(Console.ReadLine());
            //int tempn = n;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 0; j < tempn-1;j++)
            //    {
            //        Console.Write(" ");


            //    }
            //    tempn--;

            //    Console.WriteLine("*");

            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <n; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {

            //        Console.Write(" ");
            //    }

            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}


            //int n = Convert.ToInt32(Console.ReadLine());
            //int tempn = n;

            //for (int i = 1; i <= n; i++)
            //{
            //    for(int j = 0; j < n-i; j++)
            //    {
            //        Console.Write(" ");

            //    }


            //    for (int j = 0; j < i ; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine ();

            //}



            //int n = Convert.ToInt32(Console.ReadLine());
            //int str = -1;


            //for (int i = 1; i <= 2*n-1; i++)
            //{
            //    if (i <= n)
            //    {
            //        for (int j = 0; j < n - i; j++)
            //        {
            //            Console.Write(" ");
            //        }

            //        //1+2*(n-1)
            //        str += 2;
            //        for (int j = 0; j < str; j++)
            //        {
            //            Console.Write("*");
            //        }


            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        for (int j = 0; j > n - i; j--)
            //        {
            //            Console.Write(" ");
            //        }


            //        str -= 2;
            //        for (int j = 0; j < str; j++)
            //        {
            //            Console.Write("*");
            //        }

            //        Console.WriteLine();
            //    }



            //}


            //九九乘法表

            //for(int i = 1; i <= 9; i++)
            //{

            //    Console.Write("{0}*{1}={2}", 1, i, i);
            //    Console.Write(" ");

            //    for (int j =2;j<=i; j++)
            //    {

            //        Console.Write("{0}*{1}={2}", j, i, j*i);
            //        Console.Write(" ");

            //    }
            //    Console.WriteLine();



            //}


            //for (int i = 1; i <= 9; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}*{1}={2}  ", j, i, j * i);
            //    }
            //    Console.WriteLine();
            //}


            //百元買雞 
            //int count = 0;

            //for(int i = 1; i <= 33; i++)
            //{
            //    for (int j = 1; j <= 20; j++)
            //    {
            //        for (int k = 1; k <= 50; k++)
            //        {
            //            if (3 * i + 5 * j + 2 * k == 100)
            //            {
            //                Console.WriteLine("公雞{0}隻 母雞{1}隻 小雞{2}隻", i, j, k);
            //                count++;

            //            }
            //        }

            //    }
            //}
            //Console.WriteLine(count);


            //最大公約數
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //if (a > b)
            //{
            //    for(int i = b; i > 0; i--)
            //    {
                    

            //        if (a % i == 0 && b % i == 0)
            //        {
            //            Console.WriteLine(i);
            //            break;


            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = a; i > 0; i--)
            //    {
            //        if (a % i == 0 && b % i == 0)
            //        {
            //            Console.WriteLine(i);
            //            break;
            //        }
            //    }
            //}



        }
    }
}
