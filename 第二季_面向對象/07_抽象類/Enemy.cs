using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_抽象類
{
    internal abstract class Enemy
    {
        private int HP;
        private int Speed;
       //抽象方法沒有函數體 {}
        public abstract void Attack();
    }
}
