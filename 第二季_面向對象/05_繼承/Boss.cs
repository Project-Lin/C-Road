using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_繼承
{
    internal class Boss:Enemy
    {
        private string color;

        public Boss(string color,int hp,int speed)
        {
            this.color = color;
            this.hp = hp;
            this.speed = speed;
        }

        public void Skill()
        {
            Console.WriteLine("BossSkill");

        }
        public void Print()
        {
            Console.WriteLine($"HP:{hp}");            //繼承自Enemy
            Console.WriteLine($"Speed:{speed}");
            Console.WriteLine($"Color:{color}");

        }
    }
}
