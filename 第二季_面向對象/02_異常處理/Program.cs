using System.ComponentModel;

namespace _02_異常處理
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////概念
            ///
            //測試語句  出現異常不會導致程式崩潰 無法執行
            //try
            //{
            //    a = Convert.ToInt32(Console.ReadLine());

            //    b = Convert.ToInt32(Console.ReadLine());
            //}
            //抓出異常 (異常類型) 類型可以不寫
            //catch (IndexOutOfRangeException e)
            //{
            //    //出現此異常執行
            //    Console.WriteLine("出現數組越界異常");
            //}
            //catch (FieldAccessException e)
            //{
            //    Console.WriteLine("出現FieldAccessException異常");
            //}
            //finally
            //{
            //    Console.WriteLine("不管如何都會執行");
            //}
            //Console.WriteLine("23");



            ///////用戶輸入兩個數字 檢測異常  方法一
            //int a = 0;
            //int b = 0;

            //while (a==0)
            //{
            //    try
            //    {

            //        a = Convert.ToInt32(Console.ReadLine());


            //    }
            //    catch
            //    {
            //        //出現此異常執行
            //        Console.WriteLine("輸入異常重新輸入");
            //    }
            //}

            //while (b==0)
            //{
            //    try
            //    {


            //        b = Convert.ToInt32(Console.ReadLine());
            //    }
            //    catch
            //    {
            //        //出現此異常執行
            //        Console.WriteLine("輸入異常重新輸入");
            //    }
            //}


            //Console.WriteLine(a+b);



            ///////用戶輸入兩個數字 檢測異常  方法二


            int a = 0;
            int b = 0;

            while (true)
            {
                try
                {

                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    //出現此異常執行
                    Console.WriteLine("輸入異常重新輸入");
                }
            }


            Console.WriteLine(a + b);
        }
    }
}
