namespace xxx2._5
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
            PtxFromt = new PictureBox();
            PtxBack = new PictureBox();
            BtnBack = new Button();
            BtnFRomt = new Button();
            BtnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)PtxFromt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PtxBack).BeginInit();
            SuspendLayout();
            // 
            // PtxFromt
            // 
            PtxFromt.Image = Properties.Resources.Ace_Spades;
            PtxFromt.Location = new Point(246, 55);
            PtxFromt.Name = "PtxFromt";
            PtxFromt.Size = new Size(118, 194);
            PtxFromt.SizeMode = PictureBoxSizeMode.Zoom;
            PtxFromt.TabIndex = 0;
            PtxFromt.TabStop = false;
            PtxFromt.Visible = false;
            // 
            // PtxBack
            // 
            PtxBack.Image = Properties.Resources.Backface_Blue;
            PtxBack.Location = new Point(74, 55);
            PtxBack.Name = "PtxBack";
            PtxBack.Size = new Size(118, 194);
            PtxBack.SizeMode = PictureBoxSizeMode.Zoom;
            PtxBack.TabIndex = 1;
            PtxBack.TabStop = false;
            PtxBack.Visible = false;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(74, 277);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(118, 69);
            BtnBack.TabIndex = 2;
            BtnBack.Text = "正面";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnFRomt
            // 
            BtnFRomt.Location = new Point(246, 277);
            BtnFRomt.Name = "BtnFRomt";
            BtnFRomt.Size = new Size(118, 69);
            BtnFRomt.TabIndex = 3;
            BtnFRomt.Text = "背面";
            BtnFRomt.UseVisualStyleBackColor = true;
            BtnFRomt.Click += BtnFRomt_Click;
            // 
            // BtnExit
            // 
            BtnExit.AutoEllipsis = true;
            BtnExit.Location = new Point(74, 375);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(290, 42);
            BtnExit.TabIndex = 4;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 467);
            Controls.Add(BtnExit);
            Controls.Add(BtnFRomt);
            Controls.Add(BtnBack);
            Controls.Add(PtxBack);
            Controls.Add(PtxFromt);
            Name = "Form1";
            Text = "開牌";
            ((System.ComponentModel.ISupportInitialize)PtxFromt).EndInit();
            ((System.ComponentModel.ISupportInitialize)PtxBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PtxFromt;
        private PictureBox PtxBack;
        private Button BtnBack;
        private Button BtnFRomt;
        private Button BtnExit;
    }
}
