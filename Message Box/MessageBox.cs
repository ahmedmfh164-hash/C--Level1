using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Message_Box
{
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void ShowMessage_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Hi this is a message!");
        }

        private void ShowMessageWithTitle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this is a message!","this is a title ahmed");

        }

        private void ShowMessageWithTitleAndButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure ?", "Confirm!"
                , MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                MessageBox.Show("user pressed ok ");
            }
            else
                MessageBox.Show("user pressed cancel");
        }

        private void ShowMessageWithTitleAndButtonAndImage_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure ?", "Confirm!",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show("user pressed ok ");
            }
            else
                MessageBox.Show("user pressed cancel");
        }

        private void ShowMessageWithTitleAndButtonAndImageAndDefaultButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure ?", "Confirm!",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.OK)
            {
                MessageBox.Show("user pressed ok ");
            }
            else
                MessageBox.Show("user pressed cancel");
        }

    }
}
