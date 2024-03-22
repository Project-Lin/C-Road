using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_繼承
{
    internal class Enemy
    {
        //private   protected    public
        //          可在子類訪問
        protected int hp;   
        protected int speed;

        public void AI()
        {
            Console.WriteLine("AI");
        }

        public void Move()
        {
            Console.WriteLine("Move");

        }

    }
}
