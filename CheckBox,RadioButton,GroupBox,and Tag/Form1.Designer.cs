namespace CheckBox_RadioButton_GroupBox_and_Tag
{
    partial class frmCheckRadioGroup
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
            this.chkReceiveEmail = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMiduam = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.gbBox1 = new System.Windows.Forms.GroupBox();
            this.rbThik = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.gbBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkReceiveEmail
            // 
            this.chkReceiveEmail.AutoSize = true;
            this.chkReceiveEmail.Location = new System.Drawing.Point(53, 100);
            this.chkReceiveEmail.Name = "chkReceiveEmail";
            this.chkReceiveEmail.Size = new System.Drawing.Size(175, 17);
            this.chkReceiveEmail.TabIndex = 0;
            this.chkReceiveEmail.Text = "Do you want to receive email ? ";
            this.chkReceiveEmail.UseVisualStyleBackColor = true;
            this.chkReceiveEmail.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(53, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(369, 99);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(50, 17);
            this.rbSmall.TabIndex = 2;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbMiduam
            // 
            this.rbMiduam.AutoSize = true;
            this.rbMiduam.Location = new System.Drawing.Point(369, 136);
            this.rbMiduam.Name = "rbMiduam";
            this.rbMiduam.Size = new System.Drawing.Size(62, 17);
            this.rbMiduam.TabIndex = 3;
            this.rbMiduam.TabStop = true;
            this.rbMiduam.Text = "Miduam";
            this.rbMiduam.UseVisualStyleBackColor = true;
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(369, 178);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(52, 17);
            this.rbLarge.TabIndex = 4;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 61);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbBox1
            // 
            this.gbBox1.Controls.Add(this.rbThik);
            this.gbBox1.Controls.Add(this.rbThin);
            this.gbBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbBox1.Location = new System.Drawing.Point(490, 82);
            this.gbBox1.Name = "gbBox1";
            this.gbBox1.Size = new System.Drawing.Size(213, 133);
            this.gbBox1.TabIndex = 8;
            this.gbBox1.TabStop = false;
            this.gbBox1.Text = "Crust";
            // 
            // rbThik
            // 
            this.rbThik.AutoSize = true;
            this.rbThik.Location = new System.Drawing.Point(30, 52);
            this.rbThik.Name = "rbThik";
            this.rbThik.Size = new System.Drawing.Size(46, 17);
            this.rbThik.TabIndex = 9;
            this.rbThik.TabStop = true;
            this.rbThik.Text = "Thik";
            this.rbThik.UseVisualStyleBackColor = true;
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Location = new System.Drawing.Point(30, 19);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(46, 17);
            this.rbThin.TabIndex = 8;
            this.rbThin.TabStop = true;
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(532, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 53);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmCheckRadioGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gbBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rbLarge);
            this.Controls.Add(this.rbMiduam);
            this.Controls.Add(this.rbSmall);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkReceiveEmail);
            this.Name = "frmCheckRadioGroup";
            this.Text = "frmCheckRedioGroup";
            this.gbBox1.ResumeLayout(false);
            this.gbBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkReceiveEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMiduam;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbBox1;
        private System.Windows.Forms.RadioButton rbThik;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.Button button3;
    }
}

