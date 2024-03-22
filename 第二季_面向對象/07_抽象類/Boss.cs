using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_抽象類
{
    internal class Boss : Enemy
    {
        public override void Attack()
        {
            Console.WriteLine("Boss攻擊");
        }
    }
}
