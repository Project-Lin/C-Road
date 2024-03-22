using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_面相對象
{
    internal class Vehicle
    {
        public int Speed;
        public int MaxSpeed;
        public int Weight;

        public void Run()
        {
            Console.WriteLine("跑");
        }

        public void Stop()
        {
            Console.WriteLine("停止");

        }
    }
}
