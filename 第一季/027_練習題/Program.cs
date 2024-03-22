using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_練習題
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 386 / 3;
            //int b = 386 % 3;
            //b + a / 3;
            //b + a % 3;

            //(386 / 3 + 386 % 3) / 3 + (386 / 3 + 386 % 3) % 3;



            // int a = 364;
            // int count = 364;


            //while(a > 2)
            // {
            //     a=a / 3 + a % 3;

            //     count += a;

            // }



            // Console.WriteLine("可以喝{0}瓶可樂，剩下{1}個空瓶", count,a);




            //字符串加密 a變d z變c 其餘不變
            //a~d 97~100  z~c 122~99

            //string a = Console.ReadLine();
            //string b ="";

            //for(int i= 0; i < a.Length; i++)
            //{
            //    if ((a[i]>='a' && a[i] <= 'w')|| (a[i] >= 'A' && a[i] <= 'W'))
            //    {
            //        b += (char)(a[i] + 3);
            //    }

            //    else if ((a[i] >='x'  && a[i] <= 'z')|| (a[i] >='X' && a[i] <='Z'))
            //    {
            //        b += (char)(a[i] - 23);
            //    }

            //    else
            //    {
            //        b += a[i];

            //    }


            //}


            //Console.WriteLine(b);




            ////
            //string a = Console.ReadLine();


            //string[] c = a.Split(' ');

            //int min =100;
            //int nub = 0;
            //string temp = c[0];


            //for(int i = 0; i < c.Length; i++)
            //{

            //    temp = c[i];

            //    char[] ar = temp.ToCharArray();

            //    int all = (ar[0]-'0') * 10 + (ar[1]-'0');

            //    if (all < min)
            //    {
            //        min = all;
            //        nub = i;

            //    }


            //}

            //temp = c[nub];

            //c[nub] = c[0];
            //c[0] = temp;



            //for (int i = 0; i < c.Length; i++)
            //{
            //    Console.Write(c[i]+" ");

            //}


            //string a = Console.ReadLine();
            //string[] b = a.Split(' ');
            //int[] c = new int[b.Length];

            //for(int i = 0; i < b.Length; i++)
            //{
            //    c[i]=Convert.ToInt32(b[i]);

            //}
            //int min = c[0];
            //int nub = 0;

            //for(int i = 1; i < b.Length; i++)
            //{
            //    if (c[i] < min)
            //    {
            //        min = c[i];
            //        nub = i;
            //    }
            //}
            //int temp = c[0];

            //c[nub] = c[0];
            //c[0] = min;

            //foreach(int t in c)
            //{
            //    Console.Write(t + " ");

            //}


            //string org = Console.ReadLine();
            //string[] arrS = org.Split(' ');
            //int[] arrI = new int[arrS.Length];

            //for(int i = 0; i < arrS.Length; i++)
            //{
            //    arrI[i] = Convert.ToInt32(arrS[i]);

            //}

            //int nub = Convert.ToInt32(Console.ReadLine());
            //int min = nub;
            //int con = -1;

            //for(int i = 0; i < arrS.Length; i++)
            //{

            //    if (arrI[i] > nub)
            //    {
            //        con = i;
            //        break;

            //    }
            //    Console.Write(arrI[i] + " ");
            //}
            //Console.Write(nub + " ");
            //if (con != -1)
            //{
            //    for (int i = con; i < arrS.Length; i++)
            //    {


            //        Console.Write(arrI[i] + " ");

            //    }
            //}



            //string org = Console.ReadLine();
            //string[] arrs = org.Split(' ');
            //int[] arri = new int[arrs.Length];

            //for(int i= 0; i < arrs.Length; i++)
            //{
            //    arri[i] = Convert.ToInt32(arrs[i]);

            //}

            //int min = arri[0];
            //int nub = 0;
            //int [] ans = new int[arrs.Length];
            //int str = 0;



            //for(int j=0; j < arrs.Length; j++)
            //{
            //    for (int i = j; i < arrs.Length; i++)
            //    {
            //        if (arri[i] < min)
            //        {
            //            min = arri[i];
            //            nub = i;

            //        }

            //    }

            //    int temp = arri[j];
            //    arri[str] = arri[nub];
            //    arri[nub] = temp;
            //    str++;
            //    foreach (int temp1 in arri)
            //    {
            //        Console.Write(temp1 + " ");
                    
            //    }
            //    Console.WriteLine();
            //}

            //string org = Console.ReadLine();
            //string[] arrs = org.Split(' ');
            //int[] arri = new int[arrs.Length];

            //for (int i = 0; i < arrs.Length; i++)
            //{
            //    arri[i] = Convert.ToInt32(arrs[i]);

            //}

            //int max = 0;
            //int nub = 0;
            //int[] ans = new int[arrs.Length];
            //bool find = false;



            //for (int j = arrs.Length-1; j >=0 ; j--)
            //{
            //    for (int i = j; i >=0; i--)
            //    {
                    

            //        if (arri[i] > max)
            //        {
            //            max = arri[i];
            //            nub = i;
            //            find = true;
            //        }

            //    }

            //    if (find == true)
            //    {
            //        int temp = arri[j];
            //        arri[j] = arri[nub];
            //        arri[nub] = temp;
            //    }

                
            //    foreach (int temp1 in arri)
            //    {
            //        Console.Write(temp1 + " ");

            //    }
            //    Console.WriteLine();
            //    max = 0;
            //    find = false;
            //}



            string org = Console.ReadLine();
            string[] arrs = org.Split(' ');
            int[] arri = new int[arrs.Length];

            for (int i = 0; i < arrs.Length; i++)
            {
                arri[i] = Convert.ToInt32(arrs[i]);

            }



            int count = 0;
            bool change = false;

            int[] ans = new int[arrs.Length];

            for(int j = 0; j < arri.Length-1; j++)
            {
                if (change == false)
                {
                    for (int i = 0; i < arri.Length - 1 - j; i++)
                    {
                        if (arri[i] > arri[i + 1])
                        {
                            int temp = arri[i + 1];
                            arri[i + 1] = arri[i];
                            arri[i] = temp;
                            change = false;
                            
                        }
                        else
                        {
                            change = true;
                        }
                        count++;
                    }
                }
                
                

            }
            foreach (int temp in arri)
            {
                Console.Write(temp + " ");

            }
            Console.WriteLine(count);




            



           













        }
    }
}
