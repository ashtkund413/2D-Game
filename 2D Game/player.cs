using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2D_Game
{
    internal class player
    {
        public int width = 30;
        public int height = 10;
        public int speed = 6;
        public int x, y;

        public player(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public void Move(string direction, Size ss)
        {
            if (direction == "left")
            {
                x -= speed;

                if (x < 0)
                {
                    x = 0;
                }
            }

            if (direction == "right")
            {
                x += speed;

                if (x > ss.Width - width)
                {
                    x = ss.Width - width;
                }
            }

            if (direction == "up" == true)
            {
                y -= speed;

                if (y < 0)
                {
                    y = 0;
                }
            }

            if (direction == "down")
            {
                y += speed;

                if (y > ss.Height - height)
                {
                    y = ss.Height - height;
                }
            }
        }
    }
}
