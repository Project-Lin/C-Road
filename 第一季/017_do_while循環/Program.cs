using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_do_while循環
{
    class Program
    {
        static void Main(string[] args)
        {
            //先執行一次 再進行判斷

            int a = 1;

            do
            {
                Console.WriteLine(a);

            } while (a<0);
        }
    }
}
