using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_密封;


namespace _09_子類的構造
{
    internal class BaseClass
    {
        private int Hp;
        private int speed;
        public BaseClass()
        {
            Console.WriteLine("BaseClass");
        }

        public BaseClass(int hp, int speed)
        {
            this.Hp = hp;
            this.speed = speed;
        }

        
    }
}
