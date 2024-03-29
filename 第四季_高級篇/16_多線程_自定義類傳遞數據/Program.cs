namespace _16_多線程_自定義類傳遞數據
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DownloadTool downloadTool = new DownloadTool("www.xxx.xxx.xxx","c/down/s/xxx/xxx");

            Thread thread = new Thread(downloadTool.Download);
            thread.Start();

        }
    }
}
