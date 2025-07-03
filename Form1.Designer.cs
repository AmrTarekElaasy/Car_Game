namespace Car_Game
{
    partial class FrmCarGame
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarGame));
            this.panelGame = new System.Windows.Forms.Panel();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minCar = new System.Windows.Forms.PictureBox();
            this.line2_2 = new System.Windows.Forms.PictureBox();
            this.line2_1 = new System.Windows.Forms.PictureBox();
            this.line2_0 = new System.Windows.Forms.PictureBox();
            this.line1_2 = new System.Windows.Forms.PictureBox();
            this.line0_2 = new System.Windows.Forms.PictureBox();
            this.line1_1 = new System.Windows.Forms.PictureBox();
            this.line0_1 = new System.Windows.Forms.PictureBox();
            this.line1_0 = new System.Windows.Forms.PictureBox();
            this.line0_0 = new System.Windows.Forms.PictureBox();
            this.timerSpeed = new System.Windows.Forms.Timer(this.components);
            this.timerBotCar = new System.Windows.Forms.Timer(this.components);
            this.timerScore = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.labelMaxScore = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line0_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line0_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line0_0)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGame.Controls.Add(this.minCar);
            this.panelGame.Controls.Add(this.labelGameOver);
            this.panelGame.Controls.Add(this.pictureBox3);
            this.panelGame.Controls.Add(this.pictureBox2);
            this.panelGame.Controls.Add(this.pictureBox1);
            this.panelGame.Controls.Add(this.line2_2);
            this.panelGame.Controls.Add(this.line2_1);
            this.panelGame.Controls.Add(this.line2_0);
            this.panelGame.Controls.Add(this.line1_2);
            this.panelGame.Controls.Add(this.line0_2);
            this.panelGame.Controls.Add(this.line1_1);
            this.panelGame.Controls.Add(this.line0_1);
            this.panelGame.Controls.Add(this.line1_0);
            this.panelGame.Controls.Add(this.line0_0);
            this.panelGame.Location = new System.Drawing.Point(0, 38);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(871, 731);
            this.panelGame.TabIndex = 0;
            this.panelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGame_Paint);
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BackColor = System.Drawing.Color.White;
            this.labelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.Location = new System.Drawing.Point(334, 237);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(162, 31);
            this.labelGameOver.TabIndex = 13;
            this.labelGameOver.Text = "Game Over";
            this.labelGameOver.Visible = false;
            this.labelGameOver.Click += new System.EventHandler(this.labelGameOver_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(110, 180);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 114);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(89, 463);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 114);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(711, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 114);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // minCar
            // 
            this.minCar.BackColor = System.Drawing.Color.Transparent;
            this.minCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minCar.BackgroundImage")));
            this.minCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minCar.Location = new System.Drawing.Point(401, 324);
            this.minCar.Name = "minCar";
            this.minCar.Size = new System.Drawing.Size(54, 114);
            this.minCar.TabIndex = 6;
            this.minCar.TabStop = false;
            // 
            // line2_2
            // 
            this.line2_2.BackColor = System.Drawing.Color.White;
            this.line2_2.Location = new System.Drawing.Point(636, 550);
            this.line2_2.Name = "line2_2";
            this.line2_2.Size = new System.Drawing.Size(18, 162);
            this.line2_2.TabIndex = 9;
            this.line2_2.TabStop = false;
            // 
            // line2_1
            // 
            this.line2_1.BackColor = System.Drawing.Color.White;
            this.line2_1.Location = new System.Drawing.Point(422, 550);
            this.line2_1.Name = "line2_1";
            this.line2_1.Size = new System.Drawing.Size(18, 162);
            this.line2_1.TabIndex = 8;
            this.line2_1.TabStop = false;
            // 
            // line2_0
            // 
            this.line2_0.BackColor = System.Drawing.Color.White;
            this.line2_0.Location = new System.Drawing.Point(207, 550);
            this.line2_0.Name = "line2_0";
            this.line2_0.Size = new System.Drawing.Size(18, 162);
            this.line2_0.TabIndex = 7;
            this.line2_0.TabStop = false;
            // 
            // line1_2
            // 
            this.line1_2.BackColor = System.Drawing.Color.White;
            this.line1_2.Location = new System.Drawing.Point(636, 296);
            this.line1_2.Name = "line1_2";
            this.line1_2.Size = new System.Drawing.Size(18, 162);
            this.line1_2.TabIndex = 5;
            this.line1_2.TabStop = false;
            this.line1_2.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // line0_2
            // 
            this.line0_2.BackColor = System.Drawing.Color.White;
            this.line0_2.Location = new System.Drawing.Point(636, 42);
            this.line0_2.Name = "line0_2";
            this.line0_2.Size = new System.Drawing.Size(18, 162);
            this.line0_2.TabIndex = 4;
            this.line0_2.TabStop = false;
            // 
            // line1_1
            // 
            this.line1_1.BackColor = System.Drawing.Color.White;
            this.line1_1.Location = new System.Drawing.Point(422, 296);
            this.line1_1.Name = "line1_1";
            this.line1_1.Size = new System.Drawing.Size(18, 162);
            this.line1_1.TabIndex = 3;
            this.line1_1.TabStop = false;
            this.line1_1.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // line0_1
            // 
            this.line0_1.BackColor = System.Drawing.Color.White;
            this.line0_1.Location = new System.Drawing.Point(422, 42);
            this.line0_1.Name = "line0_1";
            this.line0_1.Size = new System.Drawing.Size(18, 162);
            this.line0_1.TabIndex = 2;
            this.line0_1.TabStop = false;
            // 
            // line1_0
            // 
            this.line1_0.BackColor = System.Drawing.Color.White;
            this.line1_0.Location = new System.Drawing.Point(207, 296);
            this.line1_0.Name = "line1_0";
            this.line1_0.Size = new System.Drawing.Size(18, 162);
            this.line1_0.TabIndex = 1;
            this.line1_0.TabStop = false;
            // 
            // line0_0
            // 
            this.line0_0.BackColor = System.Drawing.Color.White;
            this.line0_0.Location = new System.Drawing.Point(208, 42);
            this.line0_0.Name = "line0_0";
            this.line0_0.Size = new System.Drawing.Size(18, 162);
            this.line0_0.TabIndex = 0;
            this.line0_0.TabStop = false;
            // 
            // timerSpeed
            // 
            this.timerSpeed.Enabled = true;
            this.timerSpeed.Interval = 5;
            this.timerSpeed.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerBotCar
            // 
            this.timerBotCar.Enabled = true;
            this.timerBotCar.Interval = 10;
            this.timerBotCar.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerScore
            // 
            this.timerScore.Enabled = true;
            this.timerScore.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelScore.Location = new System.Drawing.Point(728, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(81, 20);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score : 0";
            // 
            // labelMaxScore
            // 
            this.labelMaxScore.AutoSize = true;
            this.labelMaxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMaxScore.Location = new System.Drawing.Point(31, 9);
            this.labelMaxScore.Name = "labelMaxScore";
            this.labelMaxScore.Size = new System.Drawing.Size(118, 20);
            this.labelMaxScore.TabIndex = 2;
            this.labelMaxScore.Text = "Max Score : 0";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSpeed.Location = new System.Drawing.Point(384, 9);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(86, 20);
            this.labelSpeed.TabIndex = 3;
            this.labelSpeed.Text = "Speed : 0";
            // 
            // FrmCarGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(871, 501);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelMaxScore);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.panelGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmCarGame";
            this.Text = "Car_Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCarGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmCarGame_KeyUp);
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line0_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line0_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line0_0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.PictureBox line1_2;
        private System.Windows.Forms.PictureBox line0_2;
        private System.Windows.Forms.PictureBox line1_1;
        private System.Windows.Forms.PictureBox line0_1;
        private System.Windows.Forms.PictureBox line1_0;
        private System.Windows.Forms.PictureBox line0_0;
        private System.Windows.Forms.Timer timerSpeed;
        private System.Windows.Forms.PictureBox minCar;
        private System.Windows.Forms.PictureBox line2_2;
        private System.Windows.Forms.PictureBox line2_1;
        private System.Windows.Forms.PictureBox line2_0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerBotCar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Timer timerScore;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelMaxScore;
        private System.Windows.Forms.Label labelSpeed;
    }
}

