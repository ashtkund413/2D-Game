using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_Game
{ //fruit but it all falls from top and you have to catch it  every 15 sec and padel gets smaller when you go up in points
    // gos faster when you do level 2 and 3 and more spawns and power ups come more 
    public partial class gamescreen : UserControl
    {
        
        player hero;
        List<powerups> power = new List<powerups>(); 
        List<spawn> dodgeBalls = new List<spawn>();
        List<powerups> fast = new List<powerups>();

        Random randGen = new Random();
        Size screenSize;
        int powerTime = 0;

        public static int gsWidth = 600;
        public static int gsHeight = 600;

        public static int lives, difficuly;
        int score = 0;
        // spawn chaseBall;
        powerups powerup;
        powerups fastred;
        spawn ball;
        bool upArrowDown = false;
        bool downArrowDown = false;
        public static bool leftArrowDown = false;
        bool rightArrowDown = false;
        bool updateSize = false;

        public gamescreen()
        {
            InitializeComponent();
            InitializeGame();
        }



        public void InitializeGame()
        {
           
              Newpowerup();

            screenSize = new Size(this.Width, this.Height);


            int x = randGen.Next(40, screenSize.Width - 40);
            int y = randGen.Next(40, screenSize.Height - 40);
            powerup = new powerups(x, y, 10, 10);
            ball = new spawn(x, y, 8, 8);
            fastred = new powerups(x, y, 10, 10);
           // chaseBall = new spawn(x, y, 8, 8);

            x = randGen.Next(40, screenSize.Width - 40);
            y = randGen.Next(40, screenSize.Height - 40);
            hero = new player(x, y);

            for (int i = 0; i < difficuly; i++)
            {
                NewBall();
                NewBall();
            }
            Refresh();
        }

        public void NewBall()
        {
            int x = randGen.Next(40, this.Width - 40);
            int y = randGen.Next(40, this.Height - 40);

            spawn b = new spawn(x, y, 8, 8);
            dodgeBalls.Add(b);
        }
        public void Newpowerup()
        {
            int x = randGen.Next(40, gsWidth - 40);
            int y = randGen.Next(40, gsHeight - 40);

            powerups p = new powerups(x, y, 8, 8);
            power.Add(p);

        }
        public void fastpowerup()
        {
            int x = randGen.Next(40, gsWidth - 40);
            int y = randGen.Next(40, gsHeight - 40);

            powerups f = new powerups(x, y, 8, 8);
            fast.Add(f);

        }


        private void gamescreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
        }

        private void gamescreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            powerup.Move(screenSize);
            powerTime++;

            if (powerTime % 100 == 0)
            {
                Newpowerup();
            }
            if (powerTime % 120 == 0)
            {
                fastpowerup();
            }
            if (updateSize == true)
            {
                if (score % 5 == 0)
                {
                    lives += 4;

                    foreach (spawn b in dodgeBalls)
                    {
                        b.size += 5;

                    }
                }
               

                updateSize = false;
            }
            if (updateSize == true)
            {
                if (updateSize == true)
                {
                    lives++;
                    foreach (powerups powers in power)
                    {
                        BackColor = Color.White;

                    }
                }

                updateSize = false;
            }

            if (leftArrowDown == true)
            {
                hero.Move("left", screenSize);
            }

            if (rightArrowDown == true)
            {
                hero.Move("right", screenSize);
            }

            if (upArrowDown == true)
            {
                hero.Move("up", screenSize);
            }

            if (downArrowDown == true)
            {
                hero.Move("down", screenSize);
            }

            ball.Move(screenSize);
            fastred.Move(screenSize);
            foreach(powerups f in fast)
            {
                f.Move(screenSize); 
            }
            foreach (spawn b in dodgeBalls)
            {
                b.Move(screenSize);
            }

            if (ball.Collision(hero))
            {
                score++;
                updateSize = true;
                NewBall();
            }

            foreach (spawn b in dodgeBalls)
            {
                if (b.Collision(hero))
                { 

                    lives--;

                    if (lives == 0)
                    {
                        timer1.Enabled = false;
                        Form1.ChangeScreen(this, new gameover());
                    }
                }
            }

            foreach (powerups p in power)
            {
                p.Move(screenSize);
                if (p.powerUpCollision(hero))
                {
                    // ball.size = power.size;
                    NewBall();
                    NewBall();
                    NewBall();
                 
                    foreach (spawn b in dodgeBalls)
                    {
                       
                        b.xSpeed /= 2;
                        b.ySpeed /= 2;
                    }

                }
            }
            foreach (powerups f in fast)
            {
                if (f.powerUpCollision(hero))
                {


                    foreach (spawn b in dodgeBalls)
                    {
                        b.xSpeed *= 2;
                        b.ySpeed *= 2;
                    }
                }
            Refresh();
           
        }
        }

        private void gamescreen_Paint(object sender, PaintEventArgs e)
        {
            points.Text = $"{score}";
            life.Text = $"{lives}";
         

            e.Graphics.FillEllipse(Brushes.Green, ball.x, ball.y, ball.size, ball.size);
            foreach (spawn b in dodgeBalls)
            {
                e.Graphics.FillEllipse(Brushes.Purple, b.x, b.y, b.size, b.size);
            }
                foreach (powerups powers in power)
                {
                    e.Graphics.FillEllipse(Brushes.Blue, powers.x, powers.y, powers.size, powers.size);

                }
                foreach (powerups f in fast)
            {
                e.Graphics.FillEllipse(Brushes.Red, f.x, f.y, f.size, f.size);

            }

            e.Graphics.FillRectangle(Brushes.DodgerBlue, hero.x, hero.y, hero.width, hero.height);
            
        }
        
    }
}


    

