using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_委託
{
    class Program
    {
        static double XX(double a,double b)
        {
            return a * b;

        }
        static double Divide(double a, double b)
        {
            return a / b;

        }

        delegate double MY(double a, double b);

        static void Main(string[] args)
        {
            Console.WriteLine(XX(2, 3.3));
            Console.WriteLine(Divide(4.5, 3));

            MY a;
            a = XX;

            Console.WriteLine(a(2, 33));


        }
    }
}
