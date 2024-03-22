using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_面相對象
{


    //顧客類
    internal class Customer
    {
        //屬性
        public string name;
        public string address;
        public int age;
        public string createTime;

        //構造函數   Customer c1 = new Customer();
        //                        這裡就是構造函數    (系統自動創建 按造初始值構建函數)

        //public Customer()  //空構造函數 如果沒自訂構造函數 系統自動調用這個
        //{

        //}


        //自訂構造函數 括號內讀取對應數值 可以在實例化類對象時直接賦值
        public Customer(string name, string address, int age, string createTime)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.createTime = createTime;
        }


        //函數(方法)
        public void Show()
        {
            Console.WriteLine($"姓名:{name}");
            Console.WriteLine($"地址:{address}");
            Console.WriteLine($"年齡:{age}");
            Console.WriteLine($"創建時間:{createTime}");
        }



    }

    //結構體
    struct CustomerStruct
    {
        public string name;
        public string address;
        public int age;
        public string createTime;

        //函數(方法)
        public void Show()
        {
            Console.WriteLine($"姓名:{name}");
            Console.WriteLine($"地址:{address}");
            Console.WriteLine($"年齡{age}");
            Console.WriteLine($"創建時間:{createTime}");
        }
    }


}
