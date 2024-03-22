using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_4_練習題
{
    class Program
    {
        static void Main(string[] args)
        { 
            char a = ' ';
            int all = 0;
            int temp = 0;

            do
            {
                a = (char)Console.Read();
               
                    temp = a;
                    if (temp >= '0' && temp <= '9')
                    {
                        temp = a - '0';
                       
                        all += temp;

                    }
                    else if (temp == '*')
                    {
                        all += 500;

                    }

                



            } while (a != '#');






           

            Console.WriteLine(all);

        }
    }
}
