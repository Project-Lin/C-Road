using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_接口
{
    internal class Bird : IFly
    {
        public void Fly()
        {
            Console.WriteLine("鳥起飛");
        }

        public void FlyAttack()
        {
            Console.WriteLine("鳥攻擊");
        }
    }
}
