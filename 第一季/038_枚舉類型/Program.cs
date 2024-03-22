using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038_枚舉類型
{
    class Program
    {
        enum RoleType  //枚舉類型 名
        {
            Mage,Archer,Tank,Support,Warrior    //枚舉類型 值
        }
        static void Main(string[] args)
        {
            RoleType A = RoleType.Tank;
            Console.WriteLine(A);


            int nub = (int)A;
            Console.WriteLine(nub);

        }
    }
}
