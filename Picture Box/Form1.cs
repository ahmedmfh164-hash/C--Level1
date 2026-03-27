using Picture_Box.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image= Resources.Week; 
        }

        private void btnMagnetic_Click(object sender, EventArgs e)
        {
            pictureBox1.Image= Resources.Magnatic;
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            pictureBox1.Image=Image.FromFile(@"D:\photos1\Strong.png");
        }






    }
}
