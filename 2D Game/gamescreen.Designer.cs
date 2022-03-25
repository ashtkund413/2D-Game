namespace _2D_Game
{
    partial class gamescreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.life = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // life
            // 
            this.life.AutoSize = true;
            this.life.Location = new System.Drawing.Point(461, 329);
            this.life.Name = "life";
            this.life.Size = new System.Drawing.Size(13, 13);
            this.life.TabIndex = 0;
            this.life.Text = "0";
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Location = new System.Drawing.Point(19, 329);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(13, 13);
            this.points.TabIndex = 1;
            this.points.Text = "0";
            // 
            // gamescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.points);
            this.Controls.Add(this.life);
            this.DoubleBuffered = true;
            this.Name = "gamescreen";
            this.Size = new System.Drawing.Size(478, 345);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.gamescreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamescreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.gamescreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label life;
        private System.Windows.Forms.Label points;
    }
}
