namespace Shape_Avoidance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CirclePicture = new System.Windows.Forms.PictureBox();
            this.CoreMechanicsTimer = new System.Windows.Forms.Timer(this.components);
            this.VortexPicture = new System.Windows.Forms.PictureBox();
            this.TrianglePicture = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Restart = new System.Windows.Forms.Button();
            this.Level2 = new System.Windows.Forms.Button();
            this.StageTimer = new System.Windows.Forms.Timer(this.components);
            this.SquarePicture = new System.Windows.Forms.PictureBox();
            this.Scorebox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ScoreTimer = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.TitleBox = new System.Windows.Forms.PictureBox();
            this.Outofbounds = new System.Windows.Forms.PictureBox();
            this.BackgroundPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VortexPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrianglePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquarePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Outofbounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CirclePicture
            // 
            this.CirclePicture.Image = ((System.Drawing.Image)(resources.GetObject("CirclePicture.Image")));
            this.CirclePicture.Location = new System.Drawing.Point(120, 123);
            this.CirclePicture.Name = "CirclePicture";
            this.CirclePicture.Size = new System.Drawing.Size(30, 27);
            this.CirclePicture.TabIndex = 0;
            this.CirclePicture.TabStop = false;
            // 
            // CoreMechanicsTimer
            // 
            this.CoreMechanicsTimer.Interval = 1;
            this.CoreMechanicsTimer.Tick += new System.EventHandler(this.CoreMechanicsTimer_Tick);
            // 
            // VortexPicture
            // 
            this.VortexPicture.Image = ((System.Drawing.Image)(resources.GetObject("VortexPicture.Image")));
            this.VortexPicture.Location = new System.Drawing.Point(655, -2);
            this.VortexPicture.Name = "VortexPicture";
            this.VortexPicture.Size = new System.Drawing.Size(48, 266);
            this.VortexPicture.TabIndex = 1;
            this.VortexPicture.TabStop = false;
            // 
            // TrianglePicture
            // 
            this.TrianglePicture.Image = ((System.Drawing.Image)(resources.GetObject("TrianglePicture.Image")));
            this.TrianglePicture.Location = new System.Drawing.Point(120, 99);
            this.TrianglePicture.Name = "TrianglePicture";
            this.TrianglePicture.Size = new System.Drawing.Size(31, 27);
            this.TrianglePicture.TabIndex = 3;
            this.TrianglePicture.TabStop = false;
            this.TrianglePicture.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(274, 13);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(398, 13);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Visible = false;
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(299, 127);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(75, 23);
            this.Restart.TabIndex = 8;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Level2
            // 
            this.Level2.Location = new System.Drawing.Point(289, 127);
            this.Level2.Name = "Level2";
            this.Level2.Size = new System.Drawing.Size(95, 23);
            this.Level2.TabIndex = 9;
            this.Level2.Text = "New Shape?";
            this.Level2.UseVisualStyleBackColor = true;
            this.Level2.Visible = false;
            this.Level2.Click += new System.EventHandler(this.Level2_Click);
            // 
            // StageTimer
            // 
            this.StageTimer.Enabled = true;
            this.StageTimer.Interval = 10000;
            this.StageTimer.Tick += new System.EventHandler(this.StageTimer_Tick);
            // 
            // SquarePicture
            // 
            this.SquarePicture.Image = ((System.Drawing.Image)(resources.GetObject("SquarePicture.Image")));
            this.SquarePicture.Location = new System.Drawing.Point(121, 156);
            this.SquarePicture.Name = "SquarePicture";
            this.SquarePicture.Size = new System.Drawing.Size(30, 27);
            this.SquarePicture.TabIndex = 10;
            this.SquarePicture.TabStop = false;
            this.SquarePicture.Visible = false;
            // 
            // Scorebox
            // 
            this.Scorebox.BackColor = System.Drawing.SystemColors.WindowText;
            this.Scorebox.ForeColor = System.Drawing.Color.Red;
            this.Scorebox.Location = new System.Drawing.Point(0, 18);
            this.Scorebox.Name = "Scorebox";
            this.Scorebox.ReadOnly = true;
            this.Scorebox.Size = new System.Drawing.Size(55, 20);
            this.Scorebox.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox5.ForeColor = System.Drawing.Color.Red;
            this.textBox5.Location = new System.Drawing.Point(0, 0);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(42, 20);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "Score";
            // 
            // ScoreTimer
            // 
            this.ScoreTimer.Enabled = true;
            this.ScoreTimer.Interval = 1000;
            this.ScoreTimer.Tick += new System.EventHandler(this.ScoreTimer_Tick);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(499, 225);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 13;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TitleBox
            // 
            this.TitleBox.Image = ((System.Drawing.Image)(resources.GetObject("TitleBox.Image")));
            this.TitleBox.Location = new System.Drawing.Point(0, 0);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(703, 264);
            this.TitleBox.TabIndex = 14;
            this.TitleBox.TabStop = false;
            // 
            // Outofbounds
            // 
            this.Outofbounds.Image = ((System.Drawing.Image)(resources.GetObject("Outofbounds.Image")));
            this.Outofbounds.Location = new System.Drawing.Point(0, -2);
            this.Outofbounds.Name = "Outofbounds";
            this.Outofbounds.Size = new System.Drawing.Size(703, 266);
            this.Outofbounds.TabIndex = 15;
            this.Outofbounds.TabStop = false;
            this.Outofbounds.Visible = false;
            // 
            // BackgroundPicture
            // 
            this.BackgroundPicture.Image = ((System.Drawing.Image)(resources.GetObject("BackgroundPicture.Image")));
            this.BackgroundPicture.Location = new System.Drawing.Point(0, -2);
            this.BackgroundPicture.Name = "BackgroundPicture";
            this.BackgroundPicture.Size = new System.Drawing.Size(658, 266);
            this.BackgroundPicture.TabIndex = 2;
            this.BackgroundPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 260);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Scorebox);
            this.Controls.Add(this.Level2);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.VortexPicture);
            this.Controls.Add(this.CirclePicture);
            this.Controls.Add(this.TrianglePicture);
            this.Controls.Add(this.SquarePicture);
            this.Controls.Add(this.Outofbounds);
            this.Controls.Add(this.BackgroundPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CirclePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VortexPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrianglePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquarePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Outofbounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CirclePicture;
        private System.Windows.Forms.Timer CoreMechanicsTimer;
        private System.Windows.Forms.PictureBox VortexPicture;
        private System.Windows.Forms.PictureBox TrianglePicture;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Level2;
        private System.Windows.Forms.Timer StageTimer;
        private System.Windows.Forms.PictureBox SquarePicture;
        private System.Windows.Forms.TextBox Scorebox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Timer ScoreTimer;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox TitleBox;
        private System.Windows.Forms.PictureBox Outofbounds;
        private System.Windows.Forms.PictureBox BackgroundPicture;
    }
}

