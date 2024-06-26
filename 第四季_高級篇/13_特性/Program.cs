﻿//宏定義
#define ABC

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace _13_特性
{
    internal class Program
    {
        //特性是一種用於在編譯時刻提供元數據的機制
        //棄用 特性 [Obsolete(提示訊息),true(是否報錯 預設false)]
        [Obsolete("這個方法已經棄用，請用NewTest方法")]
        private static void Test()
        {
            Console.WriteLine("test");
        }

        private static void NewTest()
        {
            Console.WriteLine("NewTest");
        }

        //條件特性 [Conditional(任意命名)] 只有在開頭第一行 有寫#define DEBUG 時才會執行
        [Conditional("ABC")]
        static void ShowMessage(string str)
        {
            Console.WriteLine(str);
        }

        //調用訊息
        //CallerLineNumber 獲取行號
        //CallerFilePath 獲取文件路徑
        //CallerMemberName 獲取方法名稱
        static void Show(string str, [CallerLineNumber] int lineNumber=0, [CallerFilePath] string filePath = "", [CallerMemberName] string member="")
        { 
            Console.WriteLine(str);
            Console.WriteLine(lineNumber);
            Console.WriteLine(filePath);
            Console.WriteLine(member);

        }

        //DebuggerStepThrough 特性 用於調試時跳過這個方法
        [DebuggerStepThrough]


        static void Main(string[] args)
        {
            
            Test();
            ShowMessage("start");

            NewTest();

            ShowMessage("end");

            Show("123");
        }
    }
}
