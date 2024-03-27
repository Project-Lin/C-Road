//StringBuilder的使用  和string的差別在於StringBuilder是可變的，而string是不可變的
//通常在需要大量操作字符串時使用StringBuilder，因為StringBuilder的性能比string更好
using System.Text;

StringBuilder sb = new StringBuilder();

//Append()方法用來將字串附加到StringBuilder的結尾
sb.Append("Hello, World!");

Console.WriteLine(sb);  //Hello, World!

//Insert()方法用來將字串插入到StringBuilder的指定位置
sb.Insert(7, "C#");

Console.WriteLine(sb); //Hello, C#World!

//Remove()方法用來刪除StringBuilder的指定位置的字符
sb.Remove(7,2);

Console.WriteLine(sb);  //Hello, World!

//Replace()方法用來替換StringBuilder的指定位置的字符
sb.Replace("World","C#");
Console.WriteLine(sb);  //Hello, C#!


//StringBuilder capacity
//StringBuilder的capacity是可以設置的，當capacity不足時，會自動擴展容量
StringBuilder stringBuilder = new StringBuilder(10);

