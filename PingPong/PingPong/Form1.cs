using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        public int speed_up = 4;
        public int speed_left = 4;
        public int score = 0;

        public Form1()
        {
            InitializeComponent();

            Random random = new Random();
            int randomNumber = random.Next(1, 30);

            ball.Left = (area.Width / randomNumber);

            timer1.Enabled = true;
            Cursor.Hide();
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            racket.Top = area.Bottom - (area.Bottom / 10);

            labelgo.Left = (area.Width / 2) - (labelgo.Width / 2);
            labelgo.Top = (area.Height / 2) - (labelgo.Height / 2);
            labelgo.Visible = false;
            labelpause.Visible = false;
            labelpause.Left = (area.Width / 2) - (labelpause.Width / 2);
            labelpause.Top = (area.Height / 2) - (labelpause.Height / 2);
            labelnumber2.Visible = false;
            levelone.Visible = false;
            levelone.Left = (area.Width / 2) - (labelgo.Width / 2);
            levelone.Top = (area.Height / 2) - (labelgo.Height / 2);
            leveltwo.Visible = false;
            leveltwo.Left = (area.Width / 2) - (labelgo.Width / 2);
            leveltwo.Top = (area.Height / 2) - (labelgo.Height / 2);
            levelthree.Visible = false;
            levelthree.Left = (area.Width / 2) - (labelgo.Width / 2);
            levelthree.Top = (area.Height / 2) - (labelgo.Height / 2);
            levelfour.Visible = false;
            levelfour.Left = (area.Width / 2) - (labelgo.Width / 2);
            levelfour.Top = (area.Height / 2) - (labelgo.Height / 2);
            levelfive.Visible = false;
            levelfive.Left = (area.Width / 2) - (labelgo.Width / 2);
            levelfive.Top = (area.Height / 2) - (labelgo.Height / 2);
            lvlone.Visible = true;
            lvltwo.Visible = false;
            lvlthree.Visible = false;
            lvlfour.Visible = false;
            lvlfive.Visible = false;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);
            ball.Left += speed_left;
            ball.Top += speed_up;


            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speed_up = -speed_up;
                score += 1;
                labelnumber.Text = score.ToString();
            }
            if (box1.Visible && ball.Bottom >= box1.Top && ball.Bottom <= box1.Bottom && ball.Left >= box1.Left && ball.Right <= box1.Right)
            {
                speed_up = -speed_up;
                score += 1;
                labelnumber.Text = score.ToString();
                box1.Hide();
            }
            if (box2.Visible && ball.Bottom >= box2.Top && ball.Bottom <= box2.Bottom && ball.Left >= box2.Left && ball.Right <= box2.Right)
            {
                speed_up = -speed_up;
                score += 1;
                racket.Width += 50;
                labelnumber.Text = score.ToString();
                box2.Hide();
            }
            if (box3.Visible && ball.Bottom >= box3.Top && ball.Bottom <= box3.Bottom && ball.Left >= box3.Left && ball.Right <= box3.Right)
            {
                speed_up = -speed_up;
                score += 1;
                racket.Width -= 40;
                labelnumber.Text = score.ToString();
                box3.Hide();
            }
            if (box4.Visible && ball.Bottom >= box4.Top && ball.Bottom <= box4.Bottom && ball.Left >= box4.Left && ball.Right <= box4.Right)
            {
                speed_up = -speed_up;
                score += 1;
                speed_left += 2;
                speed_up += 2;
                labelnumber.Text = score.ToString();
                box4.Hide();
            }
            if (box5.Visible && ball.Bottom >= box5.Top && ball.Bottom <= box5.Bottom && ball.Left >= box5.Left && ball.Right <= box5.Right)
            {
                speed_up = -speed_up;
                score += 1;
                ball.Width += 2;
                ball.Height += 2;
                labelnumber.Text = score.ToString();
                box5.Hide();
            }
            if (box6.Visible && ball.Bottom >= box6.Top && ball.Bottom <= box6.Bottom && ball.Left >= box6.Left && ball.Right <= box6.Right)
            {
                speed_up = -speed_up;
                score += 1;
                ball.Width -= 2;
                ball.Height -= 2;
                labelnumber.Text = score.ToString();
                box6.Hide();
            }
            if (box7.Visible && ball.Bottom >= box7.Top && ball.Bottom <= box7.Bottom && ball.Left >= box7.Left && ball.Right <= box7.Right)
            {
                speed_up = -speed_up;
                score += 1;
                labelnumber.Text = score.ToString();
                box7.Hide();
            }

            if (ball.Left <= area.Left)
            {
                speed_left = -speed_left;
            }
            if (ball.Right >= area.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= area.Top)
            {
                speed_up = -speed_up;
            }
            if (ball.Bottom >= area.Bottom)
            {
                timer1.Enabled = false;
                labelgo.Visible = true;
                labelnumber2.Text = score.ToString();
                labelnumber2.Visible = true;
            }

            if (score == 5)
            {
                timer1.Enabled = false;
                levelone.Visible = true; 
            }
            if (score == 15)
            {
                timer1.Enabled = false;
                leveltwo.Visible = true;
            }
            if (score == 30)
            {
                timer1.Enabled = false;
                levelthree.Visible = true;
            }
            if (score == 50)
            {
                timer1.Enabled = false;
                levelfour.Visible = true;
            }
            if (score == 70)
            {
                timer1.Enabled = false;
                levelfive.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (score == 5)
            {
                timer1.Enabled = false;
                levelone.Visible = true;
                if (e.KeyCode == Keys.C)
                {
                    box1.Visible = true;
                    box2.Visible = true;
                    box3.Visible = true;
                    box4.Visible = true;
                    box5.Visible = true;
                    box6.Visible = true;
                    box7.Visible = true;
                    racket.Width = 180;
                    Random random = new Random();
                    int randomNumber = random.Next(1, 8);
                    ball.Top = 50;
                    ball.Left = (area.Width / randomNumber);
                    score = 6;
                    labelnumber.Text = "6";
                    labelnumber2.Text = "6";
                    levelone.Visible = false;
                    lvlone.Visible = false;
                    lvltwo.Visible = true;
                    timer1.Enabled = true;
                    timer1.Start();
                    speed_left = 5;
                    speed_up = 5;
                }
            }
            if (score == 15)
            {
                timer1.Enabled = false;
                leveltwo.Visible = true;
                if (e.KeyCode == Keys.C)
                {
                    box1.Visible = true;
                    box2.Visible = true;
                    box3.Visible = true;
                    box4.Visible = true;
                    box5.Visible = true;
                    box6.Visible = true;
                    box7.Visible = true;
                    racket.Width = 140;
                    Random random = new Random();
                    int randomNumber = random.Next(1, 8);
                    ball.Top = 50;
                    ball.Left = (area.Width / randomNumber);
                    score = 16;
                    labelnumber.Text = "16";
                    labelnumber2.Text = "16";
                    leveltwo.Visible = false;
                    lvltwo.Visible = false;
                    lvlthree.Visible = true;
                    timer1.Enabled = true;
                    timer1.Start();
                    speed_left = 7;
                    speed_up = 7;
                }
            }
            if (score == 30)
            {
                timer1.Enabled = false;
                levelthree.Visible = true;
                if (e.KeyCode == Keys.C)
                {
                    box1.Visible = true;
                    box2.Visible = true;
                    box3.Visible = true;
                    box4.Visible = true;
                    box5.Visible = true;
                    box6.Visible = true;
                    box7.Visible = true;
                    racket.Width = 100;
                    Random random = new Random();
                    int randomNumber = random.Next(1, 8);
                    ball.Top = 50;
                    ball.Left = (area.Width / randomNumber);
                    score = 31;
                    labelnumber.Text = "31";
                    labelnumber2.Text = "31";
                    levelthree.Visible = false;
                    lvlthree.Visible = false;
                    lvlfour.Visible = true;
                    timer1.Enabled = true;
                    timer1.Start();
                    speed_left = 9;
                    speed_up = 9;
                }
            }
            if (score == 50)
            {
                timer1.Enabled = false;
                levelfour.Visible = true;
                if (e.KeyCode == Keys.C)
                {
                    box1.Visible = true;
                    box2.Visible = true;
                    box3.Visible = true;
                    box4.Visible = true;
                    box5.Visible = true;
                    box6.Visible = true;
                    box7.Visible = true;
                    racket.Width = 70;
                    Random random = new Random();
                    int randomNumber = random.Next(1, 8);
                    ball.Top = 50;
                    ball.Left = (area.Width / randomNumber);
                    score = 51;
                    labelnumber.Text = "51";
                    labelnumber2.Text = "51";
                    levelfour.Visible = false;
                    lvlfour.Visible = false;
                    lvlfive.Visible = true;
                    timer1.Enabled = true;
                    timer1.Start();
                    speed_left = 11;
                    speed_up = 11;
                }
            }
            if (score == 50)
            {
                timer1.Enabled = false;
                levelfive.Visible = true;
                if (e.KeyCode == Keys.C)
                {
                    box1.Visible = true;
                    box2.Visible = true;
                    box3.Visible = true;
                    box4.Visible = true;
                    box5.Visible = true;
                    box6.Visible = true;
                    box7.Visible = true;
                    racket.Width = 50;
                    Random random = new Random();
                    int randomNumber = random.Next(1, 8);
                    ball.Top = 50;
                    ball.Left = (area.Width / randomNumber);
                    score = 51;
                    labelnumber.Text = "51";
                    labelnumber2.Text = "51";
                    levelfive.Visible = false;
                    lvlfive.Visible = false;
                    lvlfive.Visible = true;
                    timer1.Enabled = true;
                    timer1.Start();
                    speed_left = 14;
                    speed_up = 14;
                }
            }

            if (e.KeyCode == Keys.Space && timer1.Enabled == false)
            {
                timer1.Enabled = true;
                timer1.Start();
                labelpause.Visible=false;
            }

            else if (e.KeyCode == Keys.Space && timer1.Enabled == true)
            {
                timer1.Enabled = false;
                labelpause.Visible = true;
            }

            if (e.KeyCode == Keys.Escape) { this.Close(); };

            if (e.KeyCode == Keys.R)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 8);
                ball.Top = 50;
                ball.Left = (area.Width / randomNumber);

                 speed_left = 3;
                 speed_up = 3;
                 score = 0;
                 labelnumber.Text = "0";
                 labelnumber2.Text = "0";
                 lvlone.Visible = true;
                 lvltwo.Visible = false;
                 leveltwo.Visible = false;
                 levelone.Visible = false;
                 timer1.Enabled = true;
                 labelgo.Visible = false;
                 box1.Visible = true;
                 box2.Visible = true;
                 box3.Visible = true;
                 box4.Visible = true;
                 box5.Visible = true;
                 box6.Visible = true;
                 box7.Visible = true;
                 labelnumber2.Visible = false;
                 lvlone.Visible = true;
                 lvltwo.Visible = false;
                 lvlthree.Visible = false;
                 lvlfour.Visible = false;
                 lvlfive.Visible = false;

            }
        }
    }
}
 