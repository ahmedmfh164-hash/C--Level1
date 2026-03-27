using ComboBox_Exercise.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComboBox_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem="Boy";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {    
            switch (comboBox1.SelectedItem.ToString().ToLower())
            {
                case "boy":
                    PictureBox1.Image = Resources.Boy;
                    lblTitle.Text = "Boy";
                    break;
                case "girl":
                    PictureBox1.Image = Resources.Girl;
                    lblTitle.Text = "Girl";
                    break;
                case "book":
                    PictureBox1.Image = Resources.Book;
                    lblTitle.Text = "Book";
                    break;
                case "pen":
                    PictureBox1.Image = Resources.Pen;
                    lblTitle.Text = "Pen";
                    break;
            }

           /* string imageName = comboBox1.SelectedItem.ToString();

            PictureBox1.Image=(Image)Properties.Resources.ResourceManager.GetObject(imageName);
            lblTitle.Text = imageName;*/

        }

     
    }
}
