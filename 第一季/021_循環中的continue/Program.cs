using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_循環中的continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //continue 終止當前循環 繼續下次循環

            for (int i = 0; i <= 100; i++)
            {
                //如果i於2等於零 就不執行後面的代碼
                if (i % 2 == 0)
                {
                    continue;
                    
                }

                Console.WriteLine(i);

            }
        }
    }
}
