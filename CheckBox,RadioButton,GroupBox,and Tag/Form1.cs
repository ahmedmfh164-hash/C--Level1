using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_RadioButton_GroupBox_and_Tag
{
    public partial class frmCheckRadioGroup : Form
    {
        public frmCheckRadioGroup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           MessageBox.Show( chkReceiveEmail.Checked.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = chkReceiveEmail.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rbSmall.Checked.ToString());
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbBox1.Visible=false;
        }
    }
}
