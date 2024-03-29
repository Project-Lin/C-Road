﻿using System.Reflection;

namespace _12_反射
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //反射是一個獲取類型信息的功能 類型信息包括類型的方法 屬性 事件等
            Type t = typeof(Class1);

            //獲取類型的名稱
            Console.WriteLine(t.Name);  //Class1

            //獲取類型的命名空間
            Console.WriteLine(t.Namespace);  //_12_反射

            //獲取類型的程序集
            Console.WriteLine(t.Assembly);  //12_反射, Version=

            //獲取類型的數據成員
            FieldInfo[] fieldInfos = t.GetFields();
            foreach (FieldInfo fieldInfo in fieldInfos)
            {
                Console.WriteLine(fieldInfo.Name);  // c
            }

            //獲取類型的屬性成員
            PropertyInfo[] propertyInfos = t.GetProperties();
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                Console.WriteLine(propertyInfo.Name);  //Name
            }

            //獲取類型的方法成員
            MethodInfo[] methodInfos = t.GetMethods();
            foreach (MethodInfo methodInfo in methodInfos)
            {
                Console.WriteLine(methodInfo.Name);  //Method1
            }

        }
    }
}
