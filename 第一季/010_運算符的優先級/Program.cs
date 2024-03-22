using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_運算符的優先級
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3 + 4 * 4;
            int b = (3 + 4) * 4;


            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
}
