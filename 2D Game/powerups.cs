using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace _2D_Game
{
    internal class powerups
    {
        public int size = 15;
        public int xSpeed, ySpeed;
        public int x, y;
        public powerups(int _x, int _y, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }

        public void Move(Size screenSize)
        {
            x = xSpeed;
            y -= ySpeed;

            
            
            //check if ball has reached right or left edge
            if (y > screenSize.Height - size )
            {
                ySpeed *= -1; ;
            }
        }

        public bool Collision(player p)
        {
            Rectangle powers = new Rectangle(x, y, size, size);
            
            Rectangle playerRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (powers.IntersectsWith(playerRec))
            { 
            }
            return false;
        }
    }
}
