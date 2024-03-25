using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_坦克大戰
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();

            //設定視窗位置在螢幕中央
            this.StartPosition = FormStartPosition.CenterScreen;


            
            
        }

        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            #region 繪製圖形
            //創建圖形物件(畫布)
            Graphics g = this.CreateGraphics();

            //創建一枝筆(顏色)
            Pen p = new Pen(Color.Black);

            //畫直線 (筆, 起點X, 起點Y, 終點X, 終點Y)
            g.DrawLine(p, 0, 0, 100, 100);

            //繪製字符串
            //創建一個字體
            Font font = new Font("標楷體", 16);
            //創建一個筆刷
            SolidBrush brush = new SolidBrush(Color.Black);
            //繪製字符串(內容, 字體, 筆刷, X, Y)
            g.DrawString("你好", font, brush, 100, 100);

            //導入圖片
            Image img = Properties.Resources.Boss;

            //使用bitmap創建star1
            Bitmap bitmap = Properties.Resources.Star1;
            //使用bitmap方法 將背景黑色變透明
            bitmap.MakeTransparent(Color.Black);
            //繪製圖片
            g.DrawImage(bitmap, 200, 200);
            
            g.DrawImage(img, 100, 100, 50, 50);
            #endregion
        }
    }
}
