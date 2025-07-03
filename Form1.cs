using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Car_Game
{
    public partial class FrmCarGame : Form
    {
        public FrmCarGame()
        {
            InitializeComponent();
        }
        enum enDirctionLAndR { eL, eR, eNull }
        enum enDirctionUAndD { eU, eD, eNull }

        enDirctionLAndR _DirctionLAndR = enDirctionLAndR.eNull;
        enDirctionUAndD _DirctionUAndD = enDirctionUAndD.eNull;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }




        int _MainSpeed = 5;
        int Speed()
        {
            return _MainSpeed+(_Score/500);
        }
        bool IsThereAnIntersection()
        {
            if (minCar.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                return true;
            }
            else if (minCar.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                return true;
            }
            else if (minCar.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                return true;
            }


            return false;
        }
        string stringOfSpeed()
        {
            return $"Speed : {Speed()}";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            

            line0_0.Top += Speed();
            line0_1.Top += Speed();
            line0_2.Top += Speed();

            line1_0.Top += Speed();
            line1_1.Top += Speed();
            line1_2.Top += Speed();

            line2_0.Top += Speed();
            line2_1.Top += Speed();
            line2_2.Top += Speed();

            labelSpeed.Text = stringOfSpeed();


            if (line0_0.Top + line0_0.Height > panelGame.Height)
            {
                line0_0.Top = 0 - line1_0.Height;
                line0_1.Top = 0 - line1_1.Height;
                line0_2.Top = 0 - line1_2.Height;
            }

            if (line1_0.Top + line1_0.Height > panelGame.Height)
            {
                line1_0.Top = 0 - line1_0.Height;
                line1_1.Top = 0 - line1_1.Height;
                line1_2.Top = 0 - line1_2.Height;
            }

            if (line2_0.Top + line2_0.Height > panelGame.Height)
            {
                line2_0.Top = 0 - line1_0.Height;
                line2_1.Top = 0 - line1_1.Height;
                line2_2.Top = 0 - line1_2.Height;
            }


            if (_DirctionLAndR == enDirctionLAndR.eL && minCar.Left > 0)
            {
                minCar.Left -= Speed();
            }
            else if (_DirctionLAndR == enDirctionLAndR.eR && minCar.Left < (panelGame.Right - minCar.Width))
            {
                minCar.Left += Speed();

            }
            if (_DirctionUAndD == enDirctionUAndD.eU && minCar.Top > 0)
            {
                minCar.Top -= Speed();
            }
            else if (_DirctionUAndD == enDirctionUAndD.eD && (minCar.Top + minCar.Height) < (this.Height - minCar.Height))
            {
                minCar.Top += Speed();

            }

           if (IsThereAnIntersection())
           {
               labelGameOver.Visible = true;
               timerSpeed.Stop();
               timerBotCar.Stop();
               timerScore.Stop();
               
              
         
           }


        }

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {

        }
        byte _MaxSpeedMinCarUAndD = 15;

        void speedUpBotCar()
        {
            if (speedBotCar > -20)
                speedBotCar--;
        }
        private void FrmCarGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (labelGameOver.Visible)
            {
                if ((e.KeyData == Keys.Space || e.KeyData == Keys.Enter || e.KeyData == Keys.Up))
                {
                    restartTheGame();
                }
            }
            
           else if (e.KeyData == Keys.Left)
            {
                _DirctionLAndR = enDirctionLAndR.eL;
            }
            else if (e.KeyData == Keys.Right)
            {
                _DirctionLAndR = enDirctionLAndR.eR;


            }
            else
                _DirctionLAndR = enDirctionLAndR.eNull;


            //  if (e.KeyData == Keys.Up)
            //  {
            //      //_DirctionUAndD = enDirctionUAndD.eU;
            //
            //      if (_Speed < _MaxSpeedMinCarUAndD)
            //          _Speed++;
            //      speedUpBotCar();
            //  }
            //  else if (e.KeyData == Keys.Down)
            //  {
            //      // _DirctionUAndD = enDirctionUAndD.eD;
            //      if (_Speed > 0)
            //          _Speed--;
            //
            //      // speedBotCar++;
            //  }
            //  else
            //      _DirctionUAndD = enDirctionUAndD.eNull;

        }

        private void FrmCarGame_KeyUp(object sender, KeyEventArgs e)
        {
            _DirctionUAndD = enDirctionUAndD.eNull;
            _DirctionLAndR = enDirctionLAndR.eNull;
        }
        int speedBotCar = -5;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        void NewPointOfBotCar(PictureBox pictureBox)
        {
            if (pictureBox.Top + pictureBox.Height > panelGame.Height)
            {
                Random rand = new Random();
                pictureBox.Location = new Point(rand.Next(0, panelGame.Width - pictureBox.Width), 0 - pictureBox.Height);
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            speedBotCar = Speed()-3;
        

            pictureBox1.Top += speedBotCar;
            pictureBox2.Top += speedBotCar;
            pictureBox3.Top += speedBotCar;
            NewPointOfBotCar(pictureBox1);
            NewPointOfBotCar(pictureBox2);
            NewPointOfBotCar(pictureBox3);


        }

        private void labelScore_Click(object sender, EventArgs e)
        {


        }

        void restartTheGame()
        {
            pictureBox1.Top = -pictureBox1.Top;
            pictureBox1.Left = 0;
            pictureBox2.Top = -pictureBox2.Top;
            pictureBox2.Left = 500;
            pictureBox3.Top = -pictureBox3.Top;
            pictureBox3.Left = 200;

            minCar.Left = (panelGame.Width - pictureBox1.Width) / 2;
            labelGameOver.Visible = false;
            timerSpeed.Start();
            timerBotCar.Start();
            timerScore.Start();
            _Score = 0;
        }
        private void labelGameOver_Click(object sender, EventArgs e)
        {

            restartTheGame();
        }

        int _Score = 0,_maxScore;

       string  GetStringScore(bool maxSore=false)
        {
            string sScorse;
            sScorse = $"Scorse : {_Score}";
            if (maxSore)
                sScorse = $"Mix Score : { _maxScore}";

            return sScorse;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            _Score+=Speed();
            labelScore.Text=GetStringScore(false);
            if(_maxScore<_Score)
            {
                _maxScore = _Score;
                labelMaxScore.Text = GetStringScore(true);

            }


        }
    }
}
