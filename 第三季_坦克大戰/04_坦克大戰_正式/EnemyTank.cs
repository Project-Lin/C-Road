using _04_坦克大戰_正式.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_坦克大戰_正式
{
    internal class EnemyTank: Movething
    {
        private static Random r = new Random();
        public  EnemyTank(int x, int y, int speed,Bitmap bmpDown, Bitmap bmpUp, Bitmap bmpRight, Bitmap bmpLeft)
        {
            this.X = x;
            this.Y = y;
            this.Speed = speed;

            this.BitmapUp = bmpUp;
            this.BitmapDown = bmpDown;  
            this.BitmapLeft = bmpLeft;
            this.BitmapRight = bmpRight;

            this.direction = Direction.Down;

        }

        public override void Update()
        {
            MoveCheck();
            Move();
            base.Update();
        }

       

        private void MoveCheck()
        {
            #region 判斷是否超出邊界
            if (direction == Direction.Up && Y - Speed <= 0)
            {
                ChangeDirection();
                return;
            }
            else if (direction == Direction.Down && Y + Speed + Height >= 450)
            {
                ChangeDirection();
                return;
            }
            else if (direction == Direction.Left && X - Speed <= 0)
            {
                ChangeDirection();
                return;
            }
            else if (direction == Direction.Right && X + Speed + Width >= 450)
            {
                ChangeDirection();
                return;
            }
            #endregion

            //判斷有沒有看其他元素發生碰撞

            //取得移動後的矩形
            Rectangle recNow = this.GetRectangle();
            //判斷未來的矩形
            switch (direction)
            {
                case Direction.Up:
                    recNow.Y -= Speed;
                    break;
                case Direction.Down:
                    recNow.Y += Speed;
                    break;
                case Direction.Left:
                    recNow.X -= Speed;
                    break;
                case Direction.Right:
                    recNow.X += Speed;
                    break;
                default:
                    break;
            }
            if (GameObjectManager.IsCollidedWall(recNow) != null)
            {
                ChangeDirection();
                return;
            }

            if (GameObjectManager.IsCollidedSteel(recNow) != null)
            {
                ChangeDirection();
                return;
            }

            if (GameObjectManager.IsCollidedBoss(recNow))
            {
                ChangeDirection();
                return;
            }

        }

        private void ChangeDirection()
        {
            while (true)
            {
                Direction dir = (Direction)r.Next(0, 4);

                if (dir == direction)
                {
                    continue;

                }
                else
                {
                    direction = dir;
                    break;
                }
            }

            MoveCheck();


        }

        private void Move()
        {

            switch (direction)
            {
                case Direction.Up:
                    this.Y -= Speed;
                    break;
                case Direction.Down:
                    this.Y += Speed;
                    break;
                case Direction.Left:
                    this.X -= Speed;
                    break;
                case Direction.Right:
                    this.X += Speed;
                    break;
                default:
                    break;
            }
        }
    }
}
