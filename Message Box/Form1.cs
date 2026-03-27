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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBoxForm_Click(object sender, EventArgs e)
        {     
            Form frm1 = new frmMessageBox();
            frm1.ShowDialog();

        }

        private void newForm_Click(object sender, EventArgs e)
        {
            Form frm = new newForm();
            frm.ShowDialog();
        }
    }
}
