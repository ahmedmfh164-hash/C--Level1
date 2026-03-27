namespace Message_Box
{
    partial class frmMessageBox
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
            this.ShowMessage = new System.Windows.Forms.Button();
            this.ShowMessageWithTitle = new System.Windows.Forms.Button();
            this.ShowMessageWithTitleAndButton = new System.Windows.Forms.Button();
            this.ShowMessageWithTitleAndButtonAndImage = new System.Windows.Forms.Button();
            this.ShowMessageWithTitleAndButtonAndImageAndDefaultBtton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowMessage
            // 
            this.ShowMessage.Location = new System.Drawing.Point(61, 93);
            this.ShowMessage.Name = "ShowMessage";
            this.ShowMessage.Size = new System.Drawing.Size(207, 75);
            this.ShowMessage.TabIndex = 0;
            this.ShowMessage.Text = "ShowMessage";
            this.ShowMessage.UseVisualStyleBackColor = true;
            this.ShowMessage.Click += new System.EventHandler(this.ShowMessage_Click);
            // 
            // ShowMessageWithTitle
            // 
            this.ShowMessageWithTitle.Location = new System.Drawing.Point(481, 93);
            this.ShowMessageWithTitle.Name = "ShowMessageWithTitle";
            this.ShowMessageWithTitle.Size = new System.Drawing.Size(207, 75);
            this.ShowMessageWithTitle.TabIndex = 1;
            this.ShowMessageWithTitle.Text = "ShowMessageWithTitle";
            this.ShowMessageWithTitle.UseVisualStyleBackColor = true;
            this.ShowMessageWithTitle.Click += new System.EventHandler(this.ShowMessageWithTitle_Click);
            // 
            // ShowMessageWithTitleAndButton
            // 
            this.ShowMessageWithTitleAndButton.Location = new System.Drawing.Point(61, 227);
            this.ShowMessageWithTitleAndButton.Name = "ShowMessageWithTitleAndButton";
            this.ShowMessageWithTitleAndButton.Size = new System.Drawing.Size(207, 75);
            this.ShowMessageWithTitleAndButton.TabIndex = 2;
            this.ShowMessageWithTitleAndButton.Text = "ShowMessageWithTitleAndButton";
            this.ShowMessageWithTitleAndButton.UseVisualStyleBackColor = true;
            this.ShowMessageWithTitleAndButton.Click += new System.EventHandler(this.ShowMessageWithTitleAndButton_Click);
            // 
            // ShowMessageWithTitleAndButtonAndImage
            // 
            this.ShowMessageWithTitleAndButtonAndImage.Location = new System.Drawing.Point(481, 227);
            this.ShowMessageWithTitleAndButtonAndImage.Name = "ShowMessageWithTitleAndButtonAndImage";
            this.ShowMessageWithTitleAndButtonAndImage.Size = new System.Drawing.Size(207, 75);
            this.ShowMessageWithTitleAndButtonAndImage.TabIndex = 3;
            this.ShowMessageWithTitleAndButtonAndImage.Text = "ShowMessageWithTitleAndButtonAndImage";
            this.ShowMessageWithTitleAndButtonAndImage.UseVisualStyleBackColor = true;
            this.ShowMessageWithTitleAndButtonAndImage.Click += new System.EventHandler(this.ShowMessageWithTitleAndButtonAndImage_Click);
            // 
            // ShowMessageWithTitleAndButtonAndImageAndDefaultBtton
            // 
            this.ShowMessageWithTitleAndButtonAndImageAndDefaultBtton.Location = new System.Drawing.Point(228, 330);
            this.ShowMessageWithTitleAndButtonAndImageAndDefaultBtton.Name = "ShowMessageWithTitleAndButtonAndImageAndDefaultBtton";
            this.ShowMessageWithTitleAndButtonAndImageAndDefaultBtton.Size = new System.Drawing.Size(336, 75);
            this.ShowMessageWithTitleAndButtonAndImageAndDefaultBtton.TabIndex = 4;
            this.ShowMessageWithTitleAndButtonAndImageAndDefaultBtton.Text = "ShowMessageWithTitleAndButtonAndImageAndDefaultButton";
            this.ShowMessageWithTitleAndButtonAndImageAndDefaultBtton.UseVisualStyleBackColor = true;
            this.ShowMessageWithTitleAndButtonAndImageAndDefaultBtton.Click += new System.EventHandler(this.ShowMessageWithTitleAndButtonAndImageAndDefaultButton_Click);
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowMessageWithTitleAndButtonAndImageAndDefaultBtton);
            this.Controls.Add(this.ShowMessageWithTitleAndButtonAndImage);
            this.Controls.Add(this.ShowMessageWithTitleAndButton);
            this.Controls.Add(this.ShowMessageWithTitle);
            this.Controls.Add(this.ShowMessage);
            this.Name = "frmMessageBox";
            this.Text = "frmMessageBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowMessage;
        private System.Windows.Forms.Button ShowMessageWithTitle;
        private System.Windows.Forms.Button ShowMessageWithTitleAndButton;
        private System.Windows.Forms.Button ShowMessageWithTitleAndButtonAndImage;
        private System.Windows.Forms.Button ShowMessageWithTitleAndButtonAndImageAndDefaultBtton;
    }
}