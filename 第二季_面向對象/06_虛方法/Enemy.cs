using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_虛方法
{
    internal class Enemy
    {
        public virtual void Move()
        {
            Console.WriteLine("敵人在移動");
        }
    }
}
