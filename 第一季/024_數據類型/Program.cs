using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_數據類型
{
    class Program
    {
        static void Main(string[] args)
        {
            //整型

            sbyte a= 127;   //有符號  -128~127
            byte b= 255;    //無符號  0~255

            short g = 32767;    //有符號  -32768 ~ 32767
            ushort h = 65535;   //無符號   0 ~ 65535


            int c = 2147483647; //有符號   -2147483648 ~ 2147483647
            uint d = 2100000000; //無符號   0 ~ 4294967295

            long e = 1234567890123456789;   //有符號  -9223372036854775808 ~ 9223372036854775807
            ulong f = 1234567890123456789;  //無符號  0 ~ 18446744073709551615


            //符點型

            float i = 4.5f ;  //
            double k = 123; //
        }
    }
}
