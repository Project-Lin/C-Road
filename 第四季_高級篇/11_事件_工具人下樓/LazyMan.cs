using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_事件_工具人下樓
{
    internal class LazyMan
    {
        public string Name { get; private set; }

        public LazyMan(string name)
        {
            Name = name;
        }

        public void TakePackage()
        {
            Console.WriteLine("幫懶人{0}拿包裹", Name);
        }

        public void TakeFood()
        {
            Console.WriteLine("幫懶人{0}拿食物", Name);
        }
    }
}
