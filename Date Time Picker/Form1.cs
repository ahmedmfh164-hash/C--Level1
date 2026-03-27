using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date_Time_Picker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToLongDateString());
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           DateTime d=dateTimePicker1.Value.AddDays(3);
            MessageBox.Show(d.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime h=dateTimePicker1.Value.AddHours(30);
            MessageBox.Show(h.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                dateTimePicker1_ValueChanged(this, EventArgs.Empty);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text= dateTimePicker1.Text+Environment.NewLine;
            label1.Text+=dateTimePicker1.Value.ToString("dd-MMM-yyyy")+Environment.NewLine;
            label1.Text+=dateTimePicker1.Value.ToString("ddddd-MMM-yyyy")+Environment.NewLine;
            label1.Text+=dateTimePicker1.Value.ToString("MM-dd-yyyy")+Environment.NewLine;
            label1.Text+=dateTimePicker1.Value.ToString("ddddd-dd-MMM-yy")+Environment.NewLine;

        }
    }
}
