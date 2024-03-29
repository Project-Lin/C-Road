using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_多線程_自定義類傳遞數據
{
    
    internal class DownloadTool
    {
        public string Url { get; private set; }
        public string SavePath { get; private set; }

        public DownloadTool(string url, string savePath)
        {
            Url = url;
            SavePath = savePath;
            
        }

        public void Download()
        {
            Console.WriteLine($"正在從{Url}下載至{SavePath}");
        }
    }
}
