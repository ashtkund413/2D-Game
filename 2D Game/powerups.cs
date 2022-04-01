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
        public int XSpeed, YSpeed;
        public int x, y;
       
           
        public powerups(int __x, int __y, int __xSpeed, int __ySpeed)
        {
            x = __x;
            y = __y;
            XSpeed = __xSpeed;
            YSpeed = __ySpeed;
        }

        public void Move(Size screenSize)
        {
            x = xSpeed;
            y -= ySpeed;

            x += XSpeed;
            y += YSpeed;
            
            //check if ball has reached right or left edge
            if (x > screenSize.Width - size || x < 0)
            {
                XSpeed *= -1; ;
            }
            
            //check if ball has reached right or left edge
            if (y > screenSize.Height - size || y < 0)
            {
             
                YSpeed *= -1; ;
            }
        }


        public bool powerUpCollision(player p)
        {
            Rectangle powers = new Rectangle(x, y, size, size);
            
            Rectangle playerRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (powers.IntersectsWith(playerRec))
            { 

                if (XSpeed > 0)
                {
                    x = p.x - size;
                }
                else
                {
                    x = p.x+ p.height;
                }
                if (YSpeed > 0)
                {
                    y = p.y - size;
                }
                else
                {
                    y = p.y + p.height;
                }
                XSpeed *= -1;
                YSpeed *= -1;
                return true;
                
            }
            return false;
        }
    }
}
