using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class Class1
    {
        
        public int[] TwoSum(int[] nums, int target)
        {
            int a = -1;
            int b = -1;


            for (int i = 0; i < nums.Length; i++)
            {
                if (a != -1 && b != -1)
                {
                    break;
                }
                int temp = target - nums[i];


                a = i;
                for (int j = a + 1; j < nums.Length; j++)
                {
                    if (nums[j] == temp)
                    {
                         b = j;
                         break;
                    }
                }


            }
            int[] result = new int[2] { a, b };
            return result;

        }
    }

}
