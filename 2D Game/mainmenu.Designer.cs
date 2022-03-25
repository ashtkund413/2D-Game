namespace _2D_Game
{
    partial class mainmenu
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
            this.level1 = new System.Windows.Forms.Button();
            this.level2 = new System.Windows.Forms.Button();
            this.level3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // level1
            // 
            this.level1.BackColor = System.Drawing.Color.Cyan;
            this.level1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.level1.Location = new System.Drawing.Point(164, 85);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(106, 45);
            this.level1.TabIndex = 0;
            this.level1.Text = "level1";
            this.level1.UseVisualStyleBackColor = false;
            this.level1.Click += new System.EventHandler(this.level1_Click);
            // 
            // level2
            // 
            this.level2.BackColor = System.Drawing.Color.DarkOrange;
            this.level2.Location = new System.Drawing.Point(164, 148);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(106, 41);
            this.level2.TabIndex = 1;
            this.level2.Text = "level2";
            this.level2.UseVisualStyleBackColor = false;
            this.level2.Click += new System.EventHandler(this.level2_Click);
            // 
            // level3
            // 
            this.level3.BackColor = System.Drawing.Color.Crimson;
            this.level3.Location = new System.Drawing.Point(164, 209);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(106, 43);
            this.level3.TabIndex = 2;
            this.level3.Text = "level3";
            this.level3.UseVisualStyleBackColor = false;
            this.level3.Click += new System.EventHandler(this.level3_Click);
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.level3);
            this.Controls.Add(this.level2);
            this.Controls.Add(this.level1);
            this.Name = "mainmenu";
            this.Size = new System.Drawing.Size(451, 366);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button level1;
        private System.Windows.Forms.Button level2;
        private System.Windows.Forms.Button level3;
    }
}
