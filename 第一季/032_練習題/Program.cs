using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_練習題
{
    class Program
    {



        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] arrS = a.Split(' ');
            int[] arri = new int[arrS.Length];


            for(int i = 0; i < arrS.Length; i++)
            {
                arri[i] = Convert.ToInt32(arrS[i]);
                 
            }


            for(int i= arri[0]; i <= arri[1]; i++)
            {
                bool issin = true;
                for (int j =2; j < i / 2 + 1; j++)
                {
                    

                    if (i % j == 0)
                    {
                        issin = false;
                        break;
                    }
                    else
                    {
                        int temp = i;
                        int d = 0;
                        while (temp > 0)
                        { 
                            //31
                            int c = 0;
                           
                            c = temp % 10;
                            temp /= 10;
                            d *=10;
                            d += c;

                        }
                        issin = true;

                        for(int k = 2; k < d / 2 + 1; k++)
                        {
                            if (d % k == 0)
                            {
                                issin = false;
                                break;
                            }
                        }
                        
                    }
                    
                }
                if (issin)
                {
                    Console.Write(i + " ");
                }
            }


        }
    }
}
