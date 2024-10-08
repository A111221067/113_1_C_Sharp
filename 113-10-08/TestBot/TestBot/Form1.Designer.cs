namespace TestBot
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
            sada4 = new Label();
            label3 = new Label();
            BtnConfirm = new Button();
            TxtFirstName = new TextBox();
            TxtLastName = new TextBox();
            LblShow = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(83, 114);
            label1.Name = "label1";
            label1.Size = new Size(189, 41);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // sada4
            // 
            sada4.AutoSize = true;
            sada4.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            sada4.Location = new Point(83, 205);
            sada4.Name = "sada4";
            sada4.Size = new Size(186, 41);
            sada4.TabIndex = 1;
            sada4.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(83, 293);
            label3.Name = "label3";
            label3.Size = new Size(177, 41);
            label3.TabIndex = 2;
            label3.Text = "Full Name:";
            label3.Click += label3_Click;
            // 
            // BtnConfirm
            // 
            BtnConfirm.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            BtnConfirm.Location = new Point(345, 392);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(145, 46);
            BtnConfirm.TabIndex = 3;
            BtnConfirm.Text = "confirm";
            BtnConfirm.UseVisualStyleBackColor = true;
            BtnConfirm.Click += BtnConfirm_Click;
            // 
            // TxtFirstName
            // 
            TxtFirstName.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            TxtFirstName.Location = new Point(289, 114);
            TxtFirstName.Name = "TxtFirstName";
            TxtFirstName.Size = new Size(284, 48);
            TxtFirstName.TabIndex = 4;
            // 
            // TxtLastName
            // 
            TxtLastName.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            TxtLastName.Location = new Point(289, 198);
            TxtLastName.Name = "TxtLastName";
            TxtLastName.Size = new Size(284, 48);
            TxtLastName.TabIndex = 5;
            // 
            // LblShow
            // 
            LblShow.BorderStyle = BorderStyle.Fixed3D;
            LblShow.Location = new Point(289, 295);
            LblShow.Name = "LblShow";
            LblShow.Size = new Size(284, 39);
            LblShow.TabIndex = 6;
            LblShow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblShow);
            Controls.Add(TxtLastName);
            Controls.Add(TxtFirstName);
            Controls.Add(BtnConfirm);
            Controls.Add(label3);
            Controls.Add(sada4);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label sada4;
        private Label label3;
        private Button BtnConfirm;
        private TextBox TxtFirstName;
        private TextBox TxtLastName;
        private Label LblShow;
    }
}
