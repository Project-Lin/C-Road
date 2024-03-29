namespace _17_前台線程和後台線程
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //將ThreadMain設定為後台執行緒 { IsBackground = true }
            //當主執行緒結束 後台執行緒會被中斷
            Thread thread = new Thread(ThreadMain) { IsBackground = true };
            thread.Start();
            Console.WriteLine("主執行緒結束");
            
        }

        static void ThreadMain()
        {
            Console.WriteLine("執行緒開始");
            Thread.Sleep(5000);
            Console.WriteLine("執行緒結束"); //主執行緒結束後 會被中斷 所以不會輸出這行
            
        }
    }
}
