using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _19_MyList
{
    internal class MyList<T>
    {
        private int count = 0;
        private int capacity = 0;
        public T[] arr=new T[0] ;

        public void Sort()
        {
            Array.Sort(arr,0,count);
        }
        public int IndexOf(T a)
        {
            
            for(int i = 0; i < count; i++)
            {
                if (a.Equals(arr[i]))
                {
                    
                    return i;
                }
                
            }
            return -1;
        }
        public int LastIndexOf(T a)
        {

            for (int i = count-1; i >= 0; i--)
            {
                if (a.Equals(arr[i]))
                {

                    return i;
                }

            }
            return -1;
        }
        public void RemoveAt(int a)
        {
            if (a < 0 || a > count - 1)
            {
                throw new System.ArgumentOutOfRangeException("索引參數超出範圍");
            }

            for (int i = a; i < count; i++)
            {
                arr[i] = arr[i+1];
            }
            arr[count] = default(T);
            count--;
        }
        public T this[int a]
        {
            
            get
            {
                if (a < 0 || a > count - 1)
                {
                    throw new System.ArgumentOutOfRangeException("索引參數超出範圍");
                }
                return arr[a];
            }
            set
            {
                if (a < 0 || a > count - 1)
                {
                    throw new System.ArgumentOutOfRangeException("索引參數超出範圍");
                }
                arr[a] = value;
            }
        }
        public int Count()
        {
            return count;
        }
        public void Insert(int a,T b)
        {
            if (a < 0 || a > count - 1)
            {
                throw new System.ArgumentOutOfRangeException("索引參數超出範圍");
            }
            count++;
            ChackL();
            if (a <= capacity)
            {
                T temp = arr[a];
                T temp2 = arr[a + 1];

                for (int i = a; i < count-1; i++)
                {
                    
                    temp2 = arr[i + 1];
                    arr[i + 1] = temp;
                    temp = temp2;
                    
                }
                
            }
           

            arr[a]=b ;
            
        }
        public void Add(T a)
        {
            count++;
            ChackL();
            arr[count-1] = a;
            
            
        }
        private void ChackL()
        {
            if (count == 1)
            {
                capacity =4;
                Array.Resize(ref arr, capacity);
            }
            if (count > capacity)
            {

                capacity *= 2;

                Array.Resize(ref arr, capacity) ;


                
            }
        }
        
        public int Capacity()
        {
            return arr.Length;
        }

        public override string ToString()
        {
            string all = "";
            for (int i=0;i<count;i++)
            {
                
                all += arr[i] + " ";
            }
            return all;
        }
    }
}
