using System.Numerics;
using System;
using System.Runtime.Intrinsics;

namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Class1 a=new Class1();
            int[] b = a.TwoSum([-1,-2, -3,-4,-5], -8);

            foreach (int i in b)
            {
                Console.WriteLine(i);
            }
           
            
            
        }
        
    }
    

}
