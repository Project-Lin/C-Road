using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_事件_工具人下樓
{
    delegate void GoOutHandler();
    internal class ToolMan
    {
        public string Name { get; private set; }

        public ToolMan(string name)
        {
            Name = name;
        }

        public event GoOutHandler GoOutEvent;
        public void GoOut()
        {
            Console.WriteLine("工具人{0}出門", Name);
            if(GoOutEvent != null)
            {
                GoOutEvent();
            }

        }
    }
}
