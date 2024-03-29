
//Regular Expression

using System.Text.RegularExpressions;

string str1 = "123123x";
string str2 = "123123";

//\d表示數字，{6}表示數字的個數為6，\w 表示字母
//這個正則表達式的意思是：字符串中包含6個數字和一個字母
//@表示不轉義
//*表示0個或多個
//+表示1個或多個
//?表示0個或1個
//^表示開頭 也表示取反
//$表示結尾

Console.WriteLine(Regex.IsMatch(str1, @"\d{6}\w"));  //True
Console.WriteLine(Regex.IsMatch(str2, @"\d{6}\w"));  //False

//命名規則的正則表達式
//^[a-zA-Z_] 以字母或下劃線開頭
//\w* 0個或多個字母或數字
Console.WriteLine(Regex.IsMatch("str", @"^[a-zA-Z_]\w*"));

//5~12位數字
Console.WriteLine(Regex.IsMatch("12345678901", @"^\d{5,12}$"));


//Regex.Replace()方法
string str3 = "Hello, World!";
//將字符串中的Hello替換為Hi
Console.WriteLine(Regex.Replace(str3, "Hello", "Hi"));  //Hi, World!


// | 表示或

Console.WriteLine(Regex.IsMatch("123", @"\d{3}|\d{4}"));  //True


//正則表達式的分組

Console.WriteLine(Regex.IsMatch("abab", @"ab{2}"));  //False abb
Console.WriteLine(Regex.IsMatch("abab", @"(ab){2}"));  //True abab

//IP4地址 0~255.0~255.0~255.0~255

Console.WriteLine(Regex.IsMatch("0.255.255.255", @"^((25[0-5]|2[0-4]\d|[01]?\d\d?)\.){3}(25[0-5]|2[0-4]\d|[01]?\d\d?)$"));