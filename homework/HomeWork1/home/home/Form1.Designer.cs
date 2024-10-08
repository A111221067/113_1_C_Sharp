namespace home
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            BntExit = new Button();
            BntShow = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(306, 78);
            label1.Name = "label1";
            label1.Size = new Size(178, 41);
            label1.TabIndex = 0;
            label1.Text = "請按撲克牌";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._8_Diamonds;
            pictureBox1.Location = new Point(77, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Jack_Diamonds;
            pictureBox2.Location = new Point(338, 167);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._6_Spades;
            pictureBox3.Location = new Point(605, 167);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(99, 140);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._5_Diamonds;
            pictureBox4.Location = new Point(212, 167);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(99, 140);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._2_Hearts;
            pictureBox5.Location = new Point(475, 167);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(99, 140);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // BntExit
            // 
            BntExit.Location = new Point(306, 382);
            BntExit.Name = "BntExit";
            BntExit.Size = new Size(166, 39);
            BntExit.TabIndex = 6;
            BntExit.Text = "Exit";
            BntExit.UseVisualStyleBackColor = true;
            BntExit.Click += BntExit_Click;
            // 
            // BntShow
            // 
            BntShow.BorderStyle = BorderStyle.Fixed3D;
            BntShow.Location = new Point(77, 339);
            BntShow.Name = "BntShow";
            BntShow.Size = new Size(627, 23);
            BntShow.TabIndex = 7;
            BntShow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BntShow);
            Controls.Add(BntExit);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button BntExit;
        private Label BntShow;
    }
}
