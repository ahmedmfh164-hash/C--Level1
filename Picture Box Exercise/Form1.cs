using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Box_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.SpringGreen;
            label1.ForeColor=Color.Red;
            rbBoy.ForeColor=Color.Blue;
            rbGirl.ForeColor=Color.Blue;
            rbBook.ForeColor=Color.Blue;
            rbPen.ForeColor=Color.Blue;
        }

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image=Image.FromFile(@"D:\Images\Boy.png");

           // label1.Text=rbBoy.Text;
           label1.Text=((RadioButton)sender).Tag.ToString();
        }

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image=Image.FromFile(@"D:\Images\Girl.png");

            //label1.Text=rbGirl.Text;
            label1.Text=((RadioButton)sender).Tag.ToString();

        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image=Image.FromFile(@"D:\Images\Book.png");

            // label1.Text=rbBook.Text;
            label1.Text=((RadioButton)sender).Tag.ToString();

        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image=Image.FromFile(@"D:\Images\Pen.png");

            //label1.Text=rbPen.Text;
            label1.Text=((RadioButton)sender).Tag.ToString();

        }
    }
}
