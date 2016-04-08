namespace PingPong
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.area = new System.Windows.Forms.Panel();
            this.lvltwo = new System.Windows.Forms.Label();
            this.lvlone = new System.Windows.Forms.Label();
            this.leveltwo = new System.Windows.Forms.Label();
            this.levelone = new System.Windows.Forms.Label();
            this.labelnumber2 = new System.Windows.Forms.Label();
            this.labelpause = new System.Windows.Forms.Label();
            this.box6 = new System.Windows.Forms.PictureBox();
            this.box5 = new System.Windows.Forms.PictureBox();
            this.box2 = new System.Windows.Forms.PictureBox();
            this.box7 = new System.Windows.Forms.PictureBox();
            this.box3 = new System.Windows.Forms.PictureBox();
            this.box4 = new System.Windows.Forms.PictureBox();
            this.box1 = new System.Windows.Forms.PictureBox();
            this.labelgo = new System.Windows.Forms.Label();
            this.labelnumber = new System.Windows.Forms.Label();
            this.labelpoint = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.levelthree = new System.Windows.Forms.Label();
            this.levelfour = new System.Windows.Forms.Label();
            this.levelfive = new System.Windows.Forms.Label();
            this.lvlthree = new System.Windows.Forms.Label();
            this.lvlfour = new System.Windows.Forms.Label();
            this.lvlfive = new System.Windows.Forms.Label();
            this.area.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // area
            // 
            this.area.Controls.Add(this.lvlfive);
            this.area.Controls.Add(this.lvlfour);
            this.area.Controls.Add(this.lvlthree);
            this.area.Controls.Add(this.levelfive);
            this.area.Controls.Add(this.levelfour);
            this.area.Controls.Add(this.levelthree);
            this.area.Controls.Add(this.lvltwo);
            this.area.Controls.Add(this.lvlone);
            this.area.Controls.Add(this.leveltwo);
            this.area.Controls.Add(this.levelone);
            this.area.Controls.Add(this.labelnumber2);
            this.area.Controls.Add(this.labelpause);
            this.area.Controls.Add(this.box6);
            this.area.Controls.Add(this.box5);
            this.area.Controls.Add(this.box2);
            this.area.Controls.Add(this.box7);
            this.area.Controls.Add(this.box3);
            this.area.Controls.Add(this.box4);
            this.area.Controls.Add(this.box1);
            this.area.Controls.Add(this.labelgo);
            this.area.Controls.Add(this.labelnumber);
            this.area.Controls.Add(this.labelpoint);
            this.area.Controls.Add(this.ball);
            this.area.Controls.Add(this.racket);
            this.area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.area.Location = new System.Drawing.Point(0, 0);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(1284, 538);
            this.area.TabIndex = 2;
            // 
            // lvltwo
            // 
            this.lvltwo.AutoSize = true;
            this.lvltwo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvltwo.Location = new System.Drawing.Point(12, 30);
            this.lvltwo.Name = "lvltwo";
            this.lvltwo.Size = new System.Drawing.Size(87, 21);
            this.lvltwo.TabIndex = 24;
            this.lvltwo.Text = "Level 2";
            // 
            // lvlone
            // 
            this.lvlone.AutoSize = true;
            this.lvlone.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvlone.Location = new System.Drawing.Point(12, 30);
            this.lvlone.Name = "lvlone";
            this.lvlone.Size = new System.Drawing.Size(87, 21);
            this.lvlone.TabIndex = 23;
            this.lvlone.Text = "Level 1";
            // 
            // leveltwo
            // 
            this.leveltwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.leveltwo.AutoSize = true;
            this.leveltwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leveltwo.Location = new System.Drawing.Point(328, 16);
            this.leveltwo.Name = "leveltwo";
            this.leveltwo.Size = new System.Drawing.Size(319, 66);
            this.leveltwo.TabIndex = 22;
            this.leveltwo.Text = "Level 2 done!\r\nPress \"C\" to continue.";
            this.leveltwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // levelone
            // 
            this.levelone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.levelone.AutoSize = true;
            this.levelone.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levelone.Location = new System.Drawing.Point(47, 136);
            this.levelone.Name = "levelone";
            this.levelone.Size = new System.Drawing.Size(319, 66);
            this.levelone.TabIndex = 21;
            this.levelone.Text = "Level 1 done!\r\nPress \"C\" to continue.";
            this.levelone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelnumber2
            // 
            this.labelnumber2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelnumber2.AutoSize = true;
            this.labelnumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelnumber2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelnumber2.Location = new System.Drawing.Point(800, 230);
            this.labelnumber2.Name = "labelnumber2";
            this.labelnumber2.Size = new System.Drawing.Size(40, 42);
            this.labelnumber2.TabIndex = 20;
            this.labelnumber2.Text = "0";
            // 
            // labelpause
            // 
            this.labelpause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelpause.AutoSize = true;
            this.labelpause.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelpause.Location = new System.Drawing.Point(173, 239);
            this.labelpause.Name = "labelpause";
            this.labelpause.Size = new System.Drawing.Size(154, 37);
            this.labelpause.TabIndex = 19;
            this.labelpause.Text = "PAUSED";
            // 
            // box6
            // 
            this.box6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.box6.Location = new System.Drawing.Point(760, 85);
            this.box6.Name = "box6";
            this.box6.Size = new System.Drawing.Size(77, 46);
            this.box6.TabIndex = 11;
            this.box6.TabStop = false;
            // 
            // box5
            // 
            this.box5.BackColor = System.Drawing.SystemColors.Highlight;
            this.box5.Location = new System.Drawing.Point(1146, 279);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(51, 37);
            this.box5.TabIndex = 10;
            this.box5.TabStop = false;
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.box2.Location = new System.Drawing.Point(227, 85);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(50, 36);
            this.box2.TabIndex = 9;
            this.box2.TabStop = false;
            // 
            // box7
            // 
            this.box7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.box7.Location = new System.Drawing.Point(1009, 112);
            this.box7.Name = "box7";
            this.box7.Size = new System.Drawing.Size(30, 19);
            this.box7.TabIndex = 8;
            this.box7.TabStop = false;
            // 
            // box3
            // 
            this.box3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.box3.Location = new System.Drawing.Point(343, 261);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(61, 36);
            this.box3.TabIndex = 7;
            this.box3.TabStop = false;
            // 
            // box4
            // 
            this.box4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.box4.Location = new System.Drawing.Point(434, 136);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(81, 49);
            this.box4.TabIndex = 6;
            this.box4.TabStop = false;
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.box1.Location = new System.Drawing.Point(777, 239);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(74, 41);
            this.box1.TabIndex = 5;
            this.box1.TabStop = false;
            // 
            // labelgo
            // 
            this.labelgo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelgo.AutoSize = true;
            this.labelgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelgo.Location = new System.Drawing.Point(482, 188);
            this.labelgo.Name = "labelgo";
            this.labelgo.Size = new System.Drawing.Size(333, 234);
            this.labelgo.TabIndex = 4;
            this.labelgo.Text = "Game Over\r\n\r\nYour final score is: \r\n\r\nR to restart\r\nESC to escape\r\n";
            this.labelgo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelnumber
            // 
            this.labelnumber.AutoSize = true;
            this.labelnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelnumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelnumber.Location = new System.Drawing.Point(85, 10);
            this.labelnumber.Name = "labelnumber";
            this.labelnumber.Size = new System.Drawing.Size(19, 20);
            this.labelnumber.TabIndex = 3;
            this.labelnumber.Text = "0";
            // 
            // labelpoint
            // 
            this.labelpoint.AutoSize = true;
            this.labelpoint.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelpoint.Location = new System.Drawing.Point(12, 9);
            this.labelpoint.Name = "labelpoint";
            this.labelpoint.Size = new System.Drawing.Size(76, 21);
            this.labelpoint.TabIndex = 2;
            this.labelpoint.Text = "Score:";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.Highlight;
            this.ball.Location = new System.Drawing.Point(41, 50);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(15, 15);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.SystemColors.GrayText;
            this.racket.Location = new System.Drawing.Point(586, 505);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 10);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // levelthree
            // 
            this.levelthree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.levelthree.AutoSize = true;
            this.levelthree.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levelthree.Location = new System.Drawing.Point(483, 236);
            this.levelthree.Name = "levelthree";
            this.levelthree.Size = new System.Drawing.Size(319, 66);
            this.levelthree.TabIndex = 25;
            this.levelthree.Text = "Level 3 done!\r\nPress \"C\" to continue.";
            this.levelthree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // levelfour
            // 
            this.levelfour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.levelfour.AutoSize = true;
            this.levelfour.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levelfour.Location = new System.Drawing.Point(506, 82);
            this.levelfour.Name = "levelfour";
            this.levelfour.Size = new System.Drawing.Size(319, 66);
            this.levelfour.TabIndex = 26;
            this.levelfour.Text = "Level 4 done!\r\nPress \"C\" to continue.";
            this.levelfour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // levelfive
            // 
            this.levelfive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.levelfive.AutoSize = true;
            this.levelfive.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levelfive.Location = new System.Drawing.Point(196, 50);
            this.levelfive.Name = "levelfive";
            this.levelfive.Size = new System.Drawing.Size(319, 66);
            this.levelfive.TabIndex = 27;
            this.levelfive.Text = "Level 5 done!\r\nPress \"C\" to continue.";
            this.levelfive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvlthree
            // 
            this.lvlthree.AutoSize = true;
            this.lvlthree.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvlthree.Location = new System.Drawing.Point(12, 30);
            this.lvlthree.Name = "lvlthree";
            this.lvlthree.Size = new System.Drawing.Size(87, 21);
            this.lvlthree.TabIndex = 28;
            this.lvlthree.Text = "Level 3";
            // 
            // lvlfour
            // 
            this.lvlfour.AutoSize = true;
            this.lvlfour.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvlfour.Location = new System.Drawing.Point(12, 30);
            this.lvlfour.Name = "lvlfour";
            this.lvlfour.Size = new System.Drawing.Size(87, 21);
            this.lvlfour.TabIndex = 29;
            this.lvlfour.Text = "Level 4";
            // 
            // lvlfive
            // 
            this.lvlfive.AutoSize = true;
            this.lvlfive.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvlfive.Location = new System.Drawing.Point(12, 30);
            this.lvlfive.Name = "lvlfive";
            this.lvlfive.Size = new System.Drawing.Size(87, 21);
            this.lvlfive.TabIndex = 30;
            this.lvlfive.Text = "Level 5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 538);
            this.Controls.Add(this.area);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.area.ResumeLayout(false);
            this.area.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel area;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Label labelnumber;
        private System.Windows.Forms.Label labelpoint;
        private System.Windows.Forms.Label labelgo;
        private System.Windows.Forms.PictureBox box1;
        private System.Windows.Forms.PictureBox box6;
        private System.Windows.Forms.PictureBox box5;
        private System.Windows.Forms.PictureBox box2;
        private System.Windows.Forms.PictureBox box7;
        private System.Windows.Forms.PictureBox box3;
        private System.Windows.Forms.PictureBox box4;
        private System.Windows.Forms.Label labelpause;
        private System.Windows.Forms.Label labelnumber2;
        private System.Windows.Forms.Label leveltwo;
        private System.Windows.Forms.Label levelone;
        private System.Windows.Forms.Label lvltwo;
        private System.Windows.Forms.Label lvlone;
        private System.Windows.Forms.Label lvlfive;
        private System.Windows.Forms.Label lvlfour;
        private System.Windows.Forms.Label lvlthree;
        private System.Windows.Forms.Label levelfive;
        private System.Windows.Forms.Label levelfour;
        private System.Windows.Forms.Label levelthree;
    }
}

