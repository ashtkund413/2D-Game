using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace _2D_Game
{
    internal class spawn
    {
        public int size = 10;
        public int xSpeed, ySpeed;
        public int x, y;
        public spawn(int _x, int _y, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }

        public void Move(Size screenSize)
        {
            x += xSpeed;
            y += ySpeed;

            //check if ball has reached right or left edge
            if (x > screenSize.Width - size || x < 0)
            {
                xSpeed *= -1; ;
            }

            //check if ball has reached right or left edge
            if (y > screenSize.Height - size || y < 0)
            {
                ySpeed *= -1; ;
            }
        }

        public bool Collision(player p)
        {
            Rectangle ballRec = new Rectangle(x, y, size, size);
            Rectangle playerRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (ballRec.IntersectsWith(playerRec))
            { 
                if (ySpeed > 0)
                {
                    y = p.y - size;
                }
                else
                {
                    y = p.y + p.height;
                }

                ySpeed *= -1;
                return true;
            }

            return false;
        }
    }
}
