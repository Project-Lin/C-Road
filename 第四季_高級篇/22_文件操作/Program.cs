namespace _22_文件操作
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FileInfo 類 用於操作文件
            //DirectoryInfo 類 用於操作文件夾

            //file.CopyTo(路徑) 複製文件  實例化方法
            FileInfo file = new FileInfo("D:\\WORK\\C#學習\\基礎\\C#Road\\第四季_高級篇\\22_文件操作\\TextFile1.txt");
            file.CopyTo("D:\\WORK\\C#學習\\基礎\\C#Road\\第四季_高級篇\\22_文件操作\\TextFile2.txt");

            //File.Copy(原文件路徑,目標文件路徑) 複製文件 靜態方法
            File.Copy(
                "D:\\WORK\\C#學習\\基礎\\C#Road\\第四季_高級篇\\22_文件操作\\TextFile1.txt",
                "D:\\WORK\\C#學習\\基礎\\C#Road\\第四季_高級篇\\22_文件操作\\TextFile3.txt");

            //Directory.CreateDirectory(路徑) 創建文件夾
            DirectoryInfo directoryInfo = new DirectoryInfo("D:\\WORK\\C#學習\\基礎\\C#Road\\第四季_高級篇\\22_文件操作");
            directoryInfo.CreateSubdirectory("Test");

            //默認路徑:當前文件夾\bin\Debug\net8.0
            Directory.CreateDirectory("Test1");
        }
    }
}
