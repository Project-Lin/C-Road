using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_索引器
{
    internal class Week
    {
        private string[] days = { "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat", "Sun" };

        private int GetDay(string day)
        {
            int i = 0;
            
            foreach (string temp in days)
            {
                if (temp == day)
                {
                    return i+1;
                }

                i++;
            }
            return -1;
                
        }

        public int this[string day]
        {
            get
            {
                return GetDay(day);
            }
        }
        
        public int this[int a]
        {
            //對數組取值時調用
            get
            {
                return 100;
            }
            //賦值時調用  c=a[1]
            set
            {
                Console.WriteLine(value);
            }
        }
        
        
    }
}
