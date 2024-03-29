using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_資源訪問衝突
{
    internal class StateObject
    {
        private object _lock = new object();
        private int state = 5;
        public void ChangeState()
        {
            //lock (_lock)
            //{
                if (state == 5)
                {
                    state++;
                    Console.WriteLine($"State ={state}:{Thread.CurrentThread.ManagedThreadId}");
                }
                state = 5;
            //}

        }
    }
}
