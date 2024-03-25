using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_坦克大戰_正式
{
    internal class GameFramework
    {
        public static Graphics g;
        public static void Start()
        {
            GameObjectManager.Start();
            GameObjectManager.CreateMap();
            GameObjectManager.CreatMyTank();

        }

        public static void Update()
        {
            //GameObjectManager.DrawMap();
            //GameObjectManager.DrawMyTank();
            GameObjectManager.Update();
        }



    }
}
