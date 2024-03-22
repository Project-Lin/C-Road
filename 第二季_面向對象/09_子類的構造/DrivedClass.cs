using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace _09_子類的構造
{
    internal class DrivedClass : BaseClass
    {
        private int attack;

        public DrivedClass()
        {
            Console.WriteLine("DrivedClass");
        }

        public DrivedClass(int attack,int hp,int speed):base(hp,speed)
        {
            this.attack = attack;
        }

        
    }
}
