using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class _13_RomanToInteger
    {
        public int romanToInt(string s)
        {
            //IVIII
            int ans = 0;
            char[] d= s.ToCharArray();
            int[] arr = new int[7];
            //[I,V,X,L,C,D,M]
            //[0,1,2,3,4,5,6]
            for (int i =d.Length-1 ;i>-1;i--)
            {
                

                if (d[i] == 'I'&& arr[1] == 0 && arr[2]==0)
                {
                    ans++;
                    arr[0]++;

                }
                if (d[i] == 'V')
                {
                    if (i != 0 && d[i - 1] == 'I')
                    {

                        ans += 4;
                        
                    }
                    else
                    {
                        ans += 5;
                    }
                    arr[1]++;

                }
                if (d[i] == 'X' && arr[2] < 4 && arr[3] == 0 && arr[4] == 0)
                {


                    if (i != 0 && d[i - 1] == 'I')
                    {
                        ans += 9;
                    }
                    else
                    {
                        ans += 10;
                    }
                    arr[2]++;


                }
                if (d[i] == 'L')
                {
                    if (i != 0 && d[i - 1] == 'X')
                    {

                        ans += 40;

                    }
                    else
                    {
                        ans += 50;
                    }
                    arr[3]++;
                    
                }
                if (d[i] == 'C'&&arr[4] < 4 && arr[5] == 0 && arr[6] ==0)
                {

                    if (i != 0 && d[i - 1] == 'X')
                    {
                        ans += 90;
                    }
                    else
                    {
                        ans += 100;
                    }
                    arr[4]++;
                    
                }
                if (d[i] == 'D')
                {
                    if (i != 0 && d[i - 1] == 'C')
                    {

                        ans += 400;

                    }
                    else
                    {
                        ans += 500;
                    }
                    arr[5]++;
                    
                }
                if (d[i] == 'M' && arr[6] < 4)
                {

                    if (i!=0&&d[i - 1] == 'C')
                    {
                        ans += 900;
                    }
                    else
                    {
                        ans += 1000;
                    }
                    arr[6]++;
                }



            }
              
            return ans;

        }   
    }
}
