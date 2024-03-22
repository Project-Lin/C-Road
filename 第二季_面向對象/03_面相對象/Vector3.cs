using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_面相對象
{
    internal class Vector3
    {
       //設定private 私有數據 只能使用在此類中
       //訪問權限
        private float x;
        private float y;
        private float z;

        //使用間接方式賦值可以加入限制判斷
        public void SetX(float temp)
        {
            if (temp < 0)
            {
                return;
            }
            x= temp;
        }
        public void SetY(float temp)
        {
            if (temp < 0)
            {
                return;
            }
            y = temp;
        }
        public void SetZ(float temp)
        {
            if (temp < 0)
            {
                return;
            }
            z = temp;
        }

        //Get方法
        public float GetX() 
        {
            return x; 
        }

        public float GetY()
        {
            return y;
        }
        public float GetZ()
        {
            return z;
        }

        //取得向量長度
        public double Length()
        {
                     //開根號
            return Math.Sqrt(x*x*y*y*z*z);
        }
    }
}
