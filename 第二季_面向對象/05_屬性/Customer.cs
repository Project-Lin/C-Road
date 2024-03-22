using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_屬性
{
    //顧客類
    internal class Customer
    {
        //數據成員
        private string name;
        private string address;
        private int age;
        private string createTime;
        public int Id {  get;private set; } //可以直接設定只讀或只寫的屬性
        //public void SetAge(int age)
        //{
        //    this.age = age;
        //}
        //public int GetAge()
        //{
        //    return this.age;
        //}

        /////以上簡寫

        public int Age
        {
            get //取值時調用   可單獨設定訪問權限 private get
            {
                return age;
            }
            set  //給Age賦值時調用 取得value
            {
                age = value;
            }
        }



        //public Customer(string name, string address, int age, string createTime)
        //{
        //    this.name = name;
        //    this.address = address;
        //    this.age = age;
        //    this.createTime = createTime;
        //}


        //函數(方法)
        public void Show()
        {
            Console.WriteLine($"姓名:{name}");
            Console.WriteLine($"地址:{address}");
            Console.WriteLine($"年齡:{age}");
            Console.WriteLine($"創建時間:{createTime}");
        }



    }

}
