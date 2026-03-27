using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView_and_ImageList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
          
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.Text); 
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
                         CheckTreeViewNode(e.Node,e.Node.Checked);
        }

        private void CheckTreeViewNode(TreeNode node, Boolean isChecked)
        {
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = isChecked;

                if (item.Nodes.Count > 0)
                {
                    this.CheckTreeViewNode(item, isChecked);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.ImageList = imageList1;

            imageList1.Images.Add(Image.FromFile(@"D:\photos1\Fruits.jpeg"));
            imageList1.Images.Add(Image.FromFile(@"D:\photos1\Apple.jpg"));
            imageList1.Images.Add(Image.FromFile(@"D:\photos1\Banana.jpeg"));


            TreeNode root = new TreeNode("Fruits");
            root.ImageIndex=2;
            root.SelectedImageIndex=2;

            TreeNode apple = new TreeNode("Apple");
            apple.ImageIndex=3;
            apple.SelectedImageIndex=3;

            TreeNode banana = new TreeNode("Banana");
            banana.ImageIndex=4;
            apple.SelectedImageIndex=4;

            root.Nodes.Add(apple);
            root.Nodes.Add(banana);
          
            treeView1.Nodes.Add(root);
        }
    }
}
