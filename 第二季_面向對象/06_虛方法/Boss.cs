using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_虛方法
{
    internal class Boss:Enemy
    {
        public override void Move()
        {
            Console.WriteLine("Boss移動方法");
        }

        public void Skill()
        {
            Console.WriteLine("Boss技能");
        }
    }
}
