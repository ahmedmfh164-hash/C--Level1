using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon=SystemIcons.Application;
            notifyIcon1.BalloonTipIcon=ToolTipIcon.Error;
            notifyIcon1.BalloonTipTitle="This is a Title";
            notifyIcon1.BalloonTipText="This is a message";
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("BalloonTip Clicked :-)");
        }
    }
}
