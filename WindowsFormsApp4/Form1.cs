using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        TreeNode MyRoot;
        System.Windows.Forms.TreeNode SelectedNode;

        public Form1()
        {
            InitializeComponent();
            MyRoot = new TreeNode("Root", 0, 0);
            treeView1.Nodes.Add(MyRoot.ToString());
            SelectedNode = null;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
           

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TreeNode newNode = new TreeNode("Root1", 0, 0);
            SelectedNode.Nodes.Add("key1", newNode.ToString(),0,0);
            SelectedNode.Nodes.Add("key1", newNode.ToString(), 0, 0);

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.Clicks == 1)
            {
                this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
                this.treeView1.ContextMenuStrip.Show();
                SelectedNode = e.Node;
            }
        }
    }
}
