using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_練習
{
    internal class B:A
    {
        public override void Fun1(int i)
        {
            base.Fun1(i+1);
        }

    }
}
