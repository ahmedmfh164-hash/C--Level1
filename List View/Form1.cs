using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)||string.IsNullOrEmpty(txtName.Text))
                return;

            ListViewItem item = new ListViewItem(txtID.Text.Trim());
            if (rbMale.Checked)
                item.ImageIndex=0;
            else
                item.ImageIndex=1;

            item.SubItems.Add(txtName.Text.Trim());
            listView1.Items.Add(item);

            txtID.Clear();
            txtName.Clear();
            txtID.Focus();


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<=10; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());

                if (i%2==0)
                {
                    item.ImageIndex=0;
                }
                else
                    item.ImageIndex=1;

                item.SubItems.Add("Person"+i);
                listView1.Items.Add(item);
            }
        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View=View.Details;
        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View =View.LargeIcon;
        }

        private void rbTitle_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View=View.Tile;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View= View.List;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
