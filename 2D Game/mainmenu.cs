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
{
    public partial class mainmenu : UserControl
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void level1_Click(object sender, EventArgs e)
        {
            gamescreen.lives = 95;
            gamescreen.difficuly = 3;
            Form1.ChangeScreen(this, new gamescreen());
        }

        private void level2_Click(object sender, EventArgs e)
        {
            gamescreen.lives = 95;
            gamescreen.difficuly = 5;
            Form1.ChangeScreen(this, new gamescreen());
        }

        private void level3_Click(object sender, EventArgs e)
        {

            gamescreen.lives = 95;
            gamescreen.difficuly = 10;
            Form1.ChangeScreen(this, new gamescreen());
        }
    }
}
