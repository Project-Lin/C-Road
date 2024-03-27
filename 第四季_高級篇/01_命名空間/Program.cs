//命名空間就像是一個資料夾，可以用來區分不同的類別，避免名稱衝突。

//命名空間可以嵌套，用「.」來區分。
//命名空間可以跨檔案，用「using」來引用。
using _01_命名空間._02_命名空間;

namespace _01_命名空間
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //命名空間可以跨專案，用「參考」來引用。
            _01_命名空間.Class1 class1 = new _01_命名空間.Class1();

            _01_命名空間._02_命名空間.Class2 class2 = new _01_命名空間._02_命名空間.Class2();
        }
    }
}
