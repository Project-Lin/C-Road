﻿// string 是一種不可變的類型，一旦創建就不能被修改，每次對字符串進行操作都會創建一個新的字符串對象。

string s = "Hello, World!";
//字符串長度
Console.WriteLine(s.Length);

//字符串比較
Console.WriteLine(s == "Hello, World!");

//字符串連接
s+= "!!!!!";
Console.WriteLine(s);

//字符串截取 類似索引器的使用方式
Console.WriteLine(s[2]);

//CompareTo
//字符串比較 0:相等 1:大於 -1:小於
Console.WriteLine(s.CompareTo("Hello, World!!!!!!"));  // 0
Console.WriteLine(s.CompareTo("Hello, World!!!!!"));  // 1
Console.WriteLine(s.CompareTo("Hello, World!!!!!!!"));   // -1

//Replace
//替換 (原字符串,替換內容)
Console.WriteLine(s.Replace("World","wwww"));   //Hello, wwww!!!!!  會保留原字符串
Console.WriteLine(s);   //Hello, World!!!!!

//Substring
//分割
string[] sArray = s.Split(',');
foreach (var item in sArray)
{
    Console.WriteLine(item);
}

//擷取子字符串 (開始位置,長度)
//H e l l o ,   W o r l  d  !
//0 1 2 3 4 5 6 7 8 9 10 11 12
Console.WriteLine(s.Substring(7,5));  //World

//ToUpper
//轉換為大寫
Console.WriteLine(s.ToUpper());

//ToLower
//轉換為小寫
Console.WriteLine(s.ToLower());

//Trim
//去除前後空格
string s1 = "  Hello, World!  ";
Console.WriteLine(s1.Trim());  //Hello, World!

//string.Concat
//字符串連接
string s2 = "Hello, ";
string s3 = "World!";
Console.WriteLine(string.Concat(s2,s3));  //Hello, World!

//string.Copy
//複製字符串
string s4 = string.Copy(s);

//CopyTo
//將字符串複製到字符數組
//CopyTo(開始位置,目標字符數組,目標字符數組的開始位置,複製的長度)
char[] c = new char[10];

s.CopyTo(0,c,0,10); //Hello, Wor
foreach (var item in c)
{
    Console.Write(item);
}

//string.Format
//格式化輸出 

int a = 10;
int b = 20;
Console.WriteLine(string.Format("{0} + {1} = {2}",a,b,a+b));  //10 + 20 = 30

//C:貨幣格式
int money = 100;
Console.WriteLine(string.Format("我有{0:C}元",money));  //我有NT$100.00元

//F:固定點格式 (保留小數點後幾位)(會四捨五入)
double d = 123.456;
Console.WriteLine(string.Format("{0:F2}",d));  //123.46

//P:百分比格式 (預設保留小數點後兩位 如果要調整小數 可以在P後面跟上數字 {0:P3} 三位小數)
double p = 0.123;
Console.WriteLine(string.Format("{0:P}",p));  //12.30%

//格式化時間
DateTime dt = DateTime.Now;
Console.WriteLine(string.Format("{0:yyyy-MM-dd HH:mm:ss}",dt));  //2021-08-26 15:00:00
//y:年 M:月 d:日 H:時(24小時制) h時(12小時制) m:分 s:秒

//dt.ToString
Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss"));  //2021-08-26 15:00:00

//IndexOf
//取得字符串索引
//H e l l o ,   W o r l  d  !
//0 1 2 3 4 5 6 7 8 9 10 11 12
Console.WriteLine(s.IndexOf("d"));  //11

//IndexOfAny
//返回指定字符在字符串中第一次出現的位置
Console.WriteLine(s.IndexOfAny(new char[] {'d','W'}));  //7

//Insert
//在指定位置插入字符串
Console.WriteLine(s.Insert(7,"C# "));  //Hello, C# World!!!!!

//Join
//連接字符串
string[] sArray2 = new string[] {"Hello","World","!"};

//Join(連接符號,字符串數組)
Console.WriteLine(string.Join("<",sArray2));  //Hello<World<!