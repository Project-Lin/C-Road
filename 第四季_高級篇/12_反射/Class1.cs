using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _12_反射
{
    internal class Class1
    {
        public string Name { get; private set; }
        private int a;
        private int b;
        public int c;

        public Class1(string name)
        {
            Name = name;
        }


        public void Method1()
        {
            Console.WriteLine("Method1");
        }

    }
}
